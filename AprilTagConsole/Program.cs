using System;
using System.Collections;
using OpenCvSharp;
namespace csharp {
    class Program {
        static void Main (string[] args) {
            Mat src = new Mat ("tag36.png", ImreadModes.Color);
            //Apriltag ap = new Apriltag ("canny", true, "tag25h9");
            Apriltag ap = new Apriltag("canny", true, "tag36h11");
            var result = ap.detect (src);
            Console.WriteLine ("Detector: " + result.Count);
            foreach (TagDetection item in result)
            {
                var AprilTag_Y = item.id.ToString();
                OpenCvSharp.Point[] Coordinate = ((TagDetection)item).points;
                int X = (Coordinate[0].X + Coordinate[1].X + Coordinate[2].X + Coordinate[3].X) / 4;
                int Y = (Coordinate[0].Y + Coordinate[1].Y + Coordinate[2].Y + Coordinate[3].Y) / 4;
                Cv2.Circle(src, X, Y, 14, OpenCvSharp.Scalar.Red, 4, LineTypes.Link8, 0);
                Console.WriteLine("ID:" + AprilTag_Y);
                Cv2.PutText(src, AprilTag_Y, new Point(X, Y), HersheyFonts.HersheySimplex, 1, Scalar.Magenta,3);
            }
            src.SaveImage("test.jpg");
        }
    }
}