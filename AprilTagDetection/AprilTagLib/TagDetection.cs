using OpenCvSharp;
namespace csharp {
    public class TagDetection 
    {
        public bool good;      // Whether the hamming distance is within the margin of error.
        public long obsCode;   // Observed Code
        public long matchCode; // Match Code
        public int id;         // Tag ID
        public int hammingDistance; // Hamming distance between Observed code and matched code
        public int rotation;
        public Point[] points; //Four corners
        public Mat homography;

        public TagDetection () 
        {
            this.obsCode = -1;
            this.id      = -1;
            this.hammingDistance = -1;
            this.rotation  = 1;
            this.good      = false;
            this.matchCode = -1;
        }

        /// <summary>
        /// Translate normal point to 2d point
        /// </summary>
        /// <returns> The 2d point which has been translated
        /// </returns>
        Point2d[] _convertPoint2Point2D ()
        {
            Point2d[] points2d = new Point2d[4];
            for (int i = 0; i < 4; i++)
            {
                points2d[i] = new Point2d (this.points[i].X, this.points[i].Y);
            }
            return points2d;
        }

        /// <summary>
        /// Get homography matrix with open CV
        /// </summary>
        void _computeHomographyOpencv () 
        {
            Point2d[] src = {
                new Point2d (-1, -1),
                new Point2d (1, -1),
                new Point2d (1, 1),
                new Point2d (-1, 1)
            };
            Point2d[] dst = _convertPoint2Point2D ();
            Mat retval    = Cv2.FindHomography (src, dst);
            this.homography = retval;
        }

        /// <summary>
        /// Get homography but not using opencv
        /// </summary>
        void _computeHomography () { }
        public void addPoint (Point[] points) 
        {
            this.points = points;
            _computeHomographyOpencv ();
        }
    }
}