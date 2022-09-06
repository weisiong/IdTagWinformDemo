/// What I have changed from the two original respotories
/// - For the respo of BlackJoker1995: https://github.com/BlackJocker1995/Apriltagcsharp
///   + I changed Chinese comments to English comments
///   + I added space between functions to have a clearer view
///   + In Apriltag.cs, I inputed lines 299 to 302 to clear mat objects
/// - For the respo of Goh Chunlin: https://github.com/goh-chunlin/WebcamWinForm
///   + I removed the codes and GUI components used for sound recording as the Apriltag detection only requests images streaming
///   + I changed variables name
///   + Instead of using two timers, I used only one timer
///   + I added a GUI component to update the list of capture devices when new devices are plugged to the computer
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using DirectShowLib; // Support display & capture videos 

using OpenCvSharp;  // Image Processing
using OpenCvSharp.Extensions;

using csharp; // AprilTag

namespace WaferProject
{
    public partial class Form1 : Form
    {   
        // Video - Variables relating to the video capture devices
        VideoCapture Video_CapturingSource; // Video source object
        Mat Video_Frame;                    // Variable to store the captured frame 
        Bitmap Video_ImageToDisplay2;       // These two variables are used to display the captured frame on the picture box the form
        Bitmap Video_ImageToDisplay1;
        bool Video_UsingImageToDisplay2 = false;
        bool Video_IsStarted            = false;
        
        // April Tag
        Apriltag April_Tag = new Apriltag ("canny", true, "tag36h11", 0.8, 1, 400); // AprilTag object, which will handle the captured frame
                                                                                     // to detect if there are apriltag inside it. The input
                                                                                     // parameters regulate the tag detection performance. Read the 
                                                                                     // Apriltag.cs file for more information. So far, the program only
                                                                                     // detect tags belong to tag36h11 family.
        /// Form Initialization
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;      
        }


        /// Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            Video_MainPannel.Visible  = true;
            Video_StartRecord.Checked = false;

            var ListofDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            foreach (var Available_Devices in ListofDevices)
            {
                Video_ListOfResource.Items.Add(Available_Devices.Name); // List all the available capture devices connected to the PC
            }
            
            // Start Timmer            
            timer1.Start();  
        }

        
        /// Main Timmer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // ------------------ VIDEO ---------------------- //
            if (Video_IsStarted == true)
            {
                if (Video_CapturingSource.IsOpened())
                {
                    try
                    {
                        Video_Frame = new Mat();
                        Video_CapturingSource.Read(Video_Frame); // Take a frame from the video capture device

                        if (Video_Frame != null)
                        {
                            var AprilTag_Detected = April_Tag.detect(Video_Frame); // Process the captured frame to detect its tags
                            AprilTag_X.Text = AprilTag_Detected.Count.ToString();
                            if ( AprilTag_Detected.Count >= 1)
                            {
                                // Calculate the center of tag and cirle and then display it
                                // This program is demonstrated with one tag inside the frame
                                AprilTag_Y.Text = ((TagDetection)AprilTag_Detected[0]).id.ToString();
                                OpenCvSharp.Point[] Coordinate = ((TagDetection)AprilTag_Detected[0]).points;
                                int X = (Coordinate[0].X + Coordinate[1].X + Coordinate[2].X + Coordinate[3].X)/4;
                                int Y = (Coordinate[0].Y + Coordinate[1].Y + Coordinate[2].Y + Coordinate[3].Y)/4;
                                Cv2.Circle(Video_Frame, X, Y, 14, OpenCvSharp.Scalar.Red, 1, LineTypes.Link8, 0);
                            }

                            
                            if (Video_ImageToDisplay2 == null)
                            {
                                Video_UsingImageToDisplay2 = true;
                                Video_ImageToDisplay2 = BitmapConverter.ToBitmap(Video_Frame);
                            }
                            else if (Video_ImageToDisplay1 == null)
                            {
                                Video_UsingImageToDisplay2 = false;
                                Video_ImageToDisplay1 = BitmapConverter.ToBitmap(Video_Frame);
                            }

                            Video_PictureBox.Image = Video_UsingImageToDisplay2 ? Video_ImageToDisplay2 : Video_ImageToDisplay1;
                        }
                    
                    }
                    catch (Exception) 
                    {
                        Video_PictureBox.Image = null;
                    }
                    finally
                    {
                        // According to OpenCVSharp instruction, these objects should be disposed to avoid memory leak
                        if (Video_Frame != null)
                        {
                            Video_Frame.Dispose();
                        }
                        if (Video_UsingImageToDisplay2 && Video_ImageToDisplay1 != null)
                        {
                            Video_ImageToDisplay1.Dispose();
                            Video_ImageToDisplay1 = null;
                        }
                        else if (!Video_UsingImageToDisplay2 && Video_ImageToDisplay2 != null)
                        {
                            Video_ImageToDisplay2.Dispose();
                            Video_ImageToDisplay2 = null;
                        }
                    }
                }
            }
            
        }


        /// Supplementary Functions For Video Capturing Process
        private void Video_StartRecord_CheckedChanged(object sender, EventArgs e)
        {
            Video_Start();

            //if (Video_StartRecord.Checked == true)
            //{
                
            //    if (Video_ListOfResource.SelectedIndex < 0)
            //    {
            //        Video_StartRecord.Checked = false;
            //        MessageBox.Show("Please choose a video device.", "Video Source Not Defined", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        Video_Start();
            //    }
            //}
            //else
            //{
            //    Video_Stop();
            //}
        }
        private void Video_UpdateResource_Click(object sender, EventArgs e)
        {
            Video_ListOfResource.Items.Clear();
            var ListofDevices = new List<DsDevice>(DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice));
            foreach (var Available_Devices in ListofDevices)
            {
                Video_ListOfResource.Items.Add(Available_Devices.Name);
            }
        }

        //const string url = "http://admin:joseph12345@192.168.1.64/ISAPI/Streaming/channels/101/picture";
        const string url = "C:\\Users\\weisi\\Web\\CaptureFiles\\2022-09-05\\pic03.jpg";
        private void button1_Click(object sender, EventArgs e)
        {
            Mat vFrame = new Mat();
            var cam = new VideoCapture();
            cam.Open(url);
            //cam.Read(vFrame);
            cam.Retrieve(vFrame);
            if (vFrame != null)
            {
                var AprilTag_Detected = April_Tag.detect(vFrame); // Process the captured frame to detect its tags
                AprilTag_X.Text = AprilTag_Detected.Count.ToString();
                //if (AprilTag_Detected.Count >= 1)
                {
                    // Calculate the center of tag and cirle and then display it
                    // This program is demonstrated with one tag inside the frame
                    AprilTag_Y.Text = ((TagDetection)AprilTag_Detected[0]).id.ToString();
                    OpenCvSharp.Point[] Coordinate = ((TagDetection)AprilTag_Detected[0]).points;
                    int X = (Coordinate[0].X + Coordinate[1].X + Coordinate[2].X + Coordinate[3].X) / 4;
                    int Y = (Coordinate[0].Y + Coordinate[1].Y + Coordinate[2].Y + Coordinate[3].Y) / 4;
                    Cv2.Circle(vFrame, X, Y, 14, OpenCvSharp.Scalar.Red, 4, LineTypes.Link8, 0);
                }


                if (Video_ImageToDisplay2 == null)
                {
                    Video_UsingImageToDisplay2 = true;
                    Video_ImageToDisplay2 = BitmapConverter.ToBitmap(vFrame);
                }
                else if (Video_ImageToDisplay1 == null)
                {
                    Video_UsingImageToDisplay2 = false;
                    Video_ImageToDisplay1 = BitmapConverter.ToBitmap(vFrame);
                }

                Video_PictureBox.Image = Video_UsingImageToDisplay2 ? Video_ImageToDisplay2 : Video_ImageToDisplay1;
            }

        }

        private void Video_Start()
        {
            Video_DisposeCameraResource();
            int SelectedDevice = Video_ListOfResource.SelectedIndex;
            //Video_CapturingSource = new VideoCapture(SelectedDevice);
            Video_CapturingSource = new VideoCapture(url);
            Video_CapturingSource.Open(1);
            //Video_CapturingSource.Open(SelectedDevice);
            Video_IsStarted = true;
        }
        private void Video_DisposeCameraResource()
        {
            // The following note is copied from Git of OpenCVSharp
            // "As mentioned above, objects of classes, such as Mat and MatExpr, have unmanaged resources and need to be manually released by calling the Dispose() method.
            // Worst of all, the +, -, *, and other operators create new objects each time, and these objects need to be disposed, or there will be memory leaks."
            if (Video_Frame != null)
            {
                Video_Frame.Dispose();
            }

            if (Video_ImageToDisplay1 != null)
            {
                Video_ImageToDisplay1.Dispose();
            }

            if (Video_ImageToDisplay2 != null)
            {
                Video_ImageToDisplay2.Dispose();
            }
        }
        private void Video_Stop()
        {
            Video_DisposeCaptureResource();
            Video_IsStarted = false;
        }
        private void Video_DisposeCaptureResource()
        {
            if (Video_CapturingSource != null)
            {
                Video_CapturingSource.Release();
                Video_CapturingSource.Dispose();
            }
        }


    }
}

