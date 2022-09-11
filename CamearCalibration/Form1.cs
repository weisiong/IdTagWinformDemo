using Emgu.CV.Structure;
using Emgu.CV;
using System.Text.RegularExpressions;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;

namespace CamearCalibration
{
    public partial class Form1 : Form
    {
        const string url = "rtsp://admin:joseph12345@192.168.1.64:554/Streaming/Channels/0101";
        //const string url = "http://admin:joseph12345@192.168.1.64/ISAPI/Streaming/channels/101/picture";
        #region declaring global variables
        private MCvPoint3D32f[][] object_corner;                                //points in world coordinate
        private PointF[][] corner_count;                                        //points in image coordinate

        //private IntrinsicCameraParameters intrinsicParam = new IntrinsicCameraParameters(5);        //camera intrinsic       
        //private ExtrinsicCameraParameters[] extrinsicParams;                                        //camera extrinsic
        private VectorOfPointF[] extrinsicParams;
        private Matrix<float> mapx = new Matrix<float>(height, width);                      //mapping matrix
        private Matrix<float> mapy = new Matrix<float>(height, width);
        private MCvTermCriteria criteria = new MCvTermCriteria(100, 1e-5);

        private VideoCapture capture1;
        private const int width = 640;      //camera resolution
        private const int height = 480;
        private Size imageSize = new Size(width, height);
        private Size patternSize;           //corner pattern
        private int nPoints;                //number of corners
        private int nImage;                 //number of images which use to calibrate
        private float square;               //the actual size of square (mm)
        private bool captureInProcess;      //the process sign of camera
        private bool isCalibrating;         //the sign of calibrating
        private bool isCalibrated;          //the sign of calibrated
        Image<Bgr, byte> imageFrame1;
        Image<Gray, byte> grayFrame1;
        private bool isCorners;             //the var is ture when there is corners file in local

        Thread newThread;                   //thread of calibrating
        #endregion

        public Form1()
        {
            InitializeComponent();
            controlsInit();
        }
        private void controlsInit()
        {
            Corners_Nx.Text = "9"; // "12";
            Corners_Ny.Text = "7"; // "8";
            Square_Size.Text = "20";
            Image_Count.Text = "20";
            radio_camera.Checked = true;

            isCalibrating = false;
            isCalibrated = false;
            captureInProcess = false;
            isCorners = false;

            Start_Calibrate.Enabled = false;
            Exit_Calibrate.Enabled = false;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            capture1.Retrieve(imageFrame1);
            if (imageFrame1 == null) return;
            CvInvoke.CvtColor(imageFrame1, grayFrame1, ColorConversion.Bgr2Gray);
            if (!isCalibrating)
            {
                pictureBox1.Image = grayFrame1;
            }
            if (isCalibrated)
            {
                Mat outFrame = new();
                //CvInvoke.Undistort(imageFrame1, outFrame, _cameraMatrix, _distCoeffs);
                pictureBox1.Image = outFrame;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            #region if capture is not created, create it now
            if (null == capture1)
            {
                try
                {
                    capture1 = new VideoCapture(0);
                    capture1.Set(CapProp.FrameWidth, width);
                    capture1.Set(CapProp.FrameHeight, height);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (null != capture1)
            {
                if (captureInProcess)
                {
                    button1.Text = "Start";
                    Application.Idle -= ProcessFrame;
                    Start_Calibrate.Enabled = false;
                    Exit_Calibrate.Enabled = false;
                }
                else
                {
                    button1.Text = "Stop";
                    Application.Idle += ProcessFrame;
                    Start_Calibrate.Enabled = true;
                    Exit_Calibrate.Enabled = true;
                }
                captureInProcess = !captureInProcess;
            }
        }

        
        public void cameraInitialize()
        {
            object_corner = new MCvPoint3D32f[nImage][];
            corner_count = new PointF[nImage][];
            extrinsicParams = new VectorOfPointF[nImage];

            for (int i = 0; i < nImage; i++)
            {
                object_corner[i] = new MCvPoint3D32f[nPoints];
                corner_count[i] = new PointF[nPoints];
            }
        }
        private void objectCorners3D(MCvPoint3D32f[][] corners3D, Size chessBoardSize, int nImages, float squareSize)
        {
            int currentImage, currentRow, currentCol;
            for (currentImage = 0; currentImage < nImages; currentImage++)
            {
                for (currentRow = 0; currentRow < chessBoardSize.Height; currentRow++)
                {
                    for (currentCol = 0; currentCol < chessBoardSize.Width; currentCol++)
                    {
                        int nPoint = currentRow * chessBoardSize.Width + currentCol;
                        corners3D[currentImage][nPoint].X = (float)currentCol * squareSize;
                        corners3D[currentImage][nPoint].Y = (float)currentRow * squareSize;
                        corners3D[currentImage][nPoint].Z = (float)0.0f;
                    }
                }
            }
        }
        //private bool findCorners(ref Image<Gray, byte> chessboardImage, out PointF[] cornersDetected)
        //{
            //Mat cornersDetected = new Mat();
            ////cornersDetected = new PointF[nPoints];

            ////cornersDetected = CameraCalibration.FindChessboardCorners(chessboardImage, patternSize, CALIB_CB_TYPE.ADAPTIVE_THRESH | CALIB_CB_TYPE.NORMALIZE_IMAGE);

            // = CvInvoke.FindChessboardCorners(chessboardImage, patternSize, cornersDetected, CalibCbType.AdaptiveThresh | CalibCbType.FastCheck | CalibCbType.NormalizeImage);

            //if (null == cornersDetected)
            //{
            //    return false;
            //}
            //else
            //{
            //    CvInvoke.cvFindCornerSubPix(chessboardImage, cornersDetected, nPoints, new Size(5, 5), new Size(-1, -1), criteria);
            //    CameraCalibration.DrawChessboardCorners(chessboardImage, patternSize, cornersDetected);
            //    return true;
            //}
        //}

        private void Read_Corners_Click(object sender, EventArgs e)
        {

        }

        private void Start_Calibrate_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Calibrate_Click(object sender, EventArgs e)
        {

        }

        private void Rectify_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}