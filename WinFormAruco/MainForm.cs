using Emgu.CV;
using Emgu.CV.Aruco;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;

namespace WinFormAruco
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CvInvoke.Init();
        }

        //const string url = "C:\\Users\\weisi\\Web\\CaptureFiles\\2022-09-05\\pic03.jpg";
        const string url = "ArucoCode.jpg";
        private void useThisFrameButton_Click(object sender, EventArgs e)
        {
            _detectorParameters = DetectorParameters.GetDefault();

            _capture = new VideoCapture(url);

            var CurrentFrame = _capture.QueryFrame();
            CurrentFrame.CopyTo(_frame);
            //_capture.Retrieve(_frame, 0);
            _frame.CopyTo(_frameCopy);
            //CurrentFrame.CopyTo(_frameCopy);
            //cameraImageBox.Image = _frame;
            using (VectorOfInt ids = new VectorOfInt())
                using (VectorOfVectorOfPointF corners = new VectorOfVectorOfPointF())
                using (VectorOfVectorOfPointF rejected = new VectorOfVectorOfPointF())
                {
                    //DetectorParameters p = DetectorParameters.GetDefault();
                    ArucoInvoke.DetectMarkers(_frameCopy, ArucoDictionary, corners, ids, _detectorParameters, rejected);

                    if (ids.Size > 0)
                    {
                        ArucoInvoke.RefineDetectedMarkers(_frameCopy, ArucoBoard, corners, ids, rejected, null, null, 10, 3, true, null, _detectorParameters);
                        //cameraButton.Text = "Calibrate camera";
                        this.Invoke((Action)delegate
                        {
                            useThisFrameButton.Enabled = true;
                        });
                        ArucoInvoke.DrawDetectedMarkers(_frameCopy, corners, ids, new MCvScalar(0, 255, 0));

                        if (!_cameraMatrix.IsEmpty && !_distCoeffs.IsEmpty)
                        {
                            ArucoInvoke.EstimatePoseSingleMarkers(corners, markersLength, _cameraMatrix, _distCoeffs, rvecs, tvecs);
                            for (int i = 0; i < ids.Size; i++)
                            {
                                using (Mat rvecMat = rvecs.Row(i))
                                using (Mat tvecMat = tvecs.Row(i))
                                using (VectorOfDouble rvec = new VectorOfDouble())
                                using (VectorOfDouble tvec = new VectorOfDouble())
                                {
                                    double[] values = new double[3];
                                    rvecMat.CopyTo(values);
                                    rvec.Push(values);
                                    tvecMat.CopyTo(values);
                                    tvec.Push(values);


                                    ArucoInvoke.DrawAxis(_frameCopy, _cameraMatrix, _distCoeffs, rvec, tvec,
                                       markersLength * 0.5f);

                                }
                            }
                        }

                        if (_useThisFrame)
                        {
                            _allCorners.Push(corners);
                            _allIds.Push(ids);
                            _markerCounterPerFrame.Push(new int[] { corners.Size });
                            _imageSize = _frame.Size;
                            UpdateMessage(String.Format("Using {0} points", _markerCounterPerFrame.ToArray().Sum()));
                            _useThisFrame = false;
                        }
                    }
                    else
                    {
                        this.Invoke((Action)delegate
                        {
                            useThisFrameButton.Enabled = false;
                        });

                        //cameraButton.Text = "Stop Capture";
                    }
                    cameraImageBox.Image = _frameCopy.Clone();
                }
            
        }

        Mat _frame = new Mat();
        Mat _frameCopy = new Mat();

        Mat _cameraMatrix = new Mat();
        Mat _distCoeffs = new Mat();
        Mat rvecs = new Mat();
        Mat tvecs = new Mat();

        private VectorOfInt _allIds = new VectorOfInt();
        private VectorOfVectorOfPointF _allCorners = new VectorOfVectorOfPointF();
        private VectorOfInt _markerCounterPerFrame = new VectorOfInt();
        private Size _imageSize = Size.Empty;

        private DetectorParameters _detectorParameters;

        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private bool _useThisFrame = false;

        int markersX = 4;
        int markersY = 4;
        int markersLength = 80;
        int markersSeparation = 30;

        private Dictionary _dict;

        private Dictionary ArucoDictionary
        {
            get
            {
                if (_dict == null)
                    _dict = new Dictionary(Dictionary.PredefinedDictionaryName.Dict4X4_100);
                return _dict;
            }

        }

        private GridBoard _gridBoard;
        private GridBoard ArucoBoard
        {
            get
            {
                if (_gridBoard == null)
                {
                    _gridBoard = new GridBoard(markersX, markersY, markersLength, markersSeparation, ArucoDictionary);
                }
                return _gridBoard;
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                _frame.CopyTo(_frameCopy);

                //cameraImageBox.Image = _frame;
                using (VectorOfInt ids = new VectorOfInt())
                using (VectorOfVectorOfPointF corners = new VectorOfVectorOfPointF())
                using (VectorOfVectorOfPointF rejected = new VectorOfVectorOfPointF())
                {
                    //DetectorParameters p = DetectorParameters.GetDefault();
                    ArucoInvoke.DetectMarkers(_frameCopy, ArucoDictionary, corners, ids, _detectorParameters, rejected);

                    if (ids.Size > 0)
                    {
                        ArucoInvoke.RefineDetectedMarkers(_frameCopy, ArucoBoard, corners, ids, rejected, null, null, 10, 3, true, null, _detectorParameters);
                        //cameraButton.Text = "Calibrate camera";
                        this.Invoke((Action)delegate
                        {
                            useThisFrameButton.Enabled = true;
                        });
                        ArucoInvoke.DrawDetectedMarkers(_frameCopy, corners, ids, new MCvScalar(0, 255, 0));

                        if (!_cameraMatrix.IsEmpty && !_distCoeffs.IsEmpty)
                        {
                            ArucoInvoke.EstimatePoseSingleMarkers(corners, markersLength, _cameraMatrix, _distCoeffs, rvecs, tvecs);
                            for (int i = 0; i < ids.Size; i++)
                            {
                                using (Mat rvecMat = rvecs.Row(i))
                                using (Mat tvecMat = tvecs.Row(i))
                                using (VectorOfDouble rvec = new VectorOfDouble())
                                using (VectorOfDouble tvec = new VectorOfDouble())
                                {
                                    double[] values = new double[3];
                                    rvecMat.CopyTo(values);
                                    rvec.Push(values);
                                    tvecMat.CopyTo(values);
                                    tvec.Push(values);


                                    ArucoInvoke.DrawAxis(_frameCopy, _cameraMatrix, _distCoeffs, rvec, tvec,
                                       markersLength * 0.5f);

                                }
                            }
                        }

                        if (_useThisFrame)
                        {
                            _allCorners.Push(corners);
                            _allIds.Push(ids);
                            _markerCounterPerFrame.Push(new int[] { corners.Size });
                            _imageSize = _frame.Size;
                            UpdateMessage(String.Format("Using {0} points", _markerCounterPerFrame.ToArray().Sum()));
                            _useThisFrame = false;
                        }
                    }
                    else
                    {
                        this.Invoke((Action)delegate
                        {
                            useThisFrameButton.Enabled = false;
                        });

                        //cameraButton.Text = "Stop Capture";
                    }
                    cameraImageBox.Image = _frameCopy.Clone();
                }
            }
            else
            {
                UpdateMessage("VideoCapture was not created");
            }
        }

        private void UpdateMessage(String message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)delegate { UpdateMessage(message); });
                return;
            }

            messageLabel.Text = message;
        }

    }
}