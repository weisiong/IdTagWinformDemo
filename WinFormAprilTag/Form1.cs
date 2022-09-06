using Emgu.CV.CvEnum;
using Emgu.CV;
using csharp;
using Emgu.CV.Structure;

namespace WinFormAprilTag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void useThisFrameButton_Click(object sender, EventArgs e)
        {
            Mat src = new ("tag36.png", ImreadModes.Color);
            //Apriltag ap = new Apriltag("canny", true, "tag16h5");
            //Apriltag ap = new Apriltag ("canny", true, "tag25h9");
            Apriltag ap = new ("canny", true, "tag36h11");
            var result = ap.detect(src);
            Console.WriteLine("Detector: " + result.Count);
            foreach (TagDetection item in result)
            {
                var AprilTag_Y = item.id.ToString();
                Point[] Coordinate = item.points;   
                int X = (Coordinate[0].X + Coordinate[1].X + Coordinate[2].X + Coordinate[3].X) / 4;
                int Y = (Coordinate[0].Y + Coordinate[1].Y + Coordinate[2].Y + Coordinate[3].Y) / 4;
                CvInvoke.Circle(src,new Point( X, Y), 14, new MCvScalar(0,0,255), 4, LineType.EightConnected, 0); 
                Console.WriteLine("ID:" + AprilTag_Y);
                CvInvoke.PutText(src, AprilTag_Y, new Point(X, Y), FontFace.HersheySimplex, 1, new MCvScalar(255, 255, 0), 3);
            }
            src.Save("test.jpg");
        }
    }
}