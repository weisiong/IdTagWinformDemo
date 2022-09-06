using Emgu.CV;

namespace csharp
{
    public class TagDetection {
        public bool good; //汉明距离是否在误差范围内 Whether the hamming distance is within the margin of error.
        public long obsCode; //解析出的code Observed Code
        public long matchCode; //匹配上的code match Code
        public int id; //匹配上的id tag`id 
        public int hammingDistance; // hamming distance between Observed code and matched code
        public int rotation;
        public Point[] points;//four corner
        public Mat homography;

        public TagDetection()
        {
            this.obsCode = -1;
            this.id = -1;
            this.hammingDistance = -1;
            this.rotation = 1;
            this.good = false;
            this.matchCode = -1;

        }
        /// <summary>
        /// 将Point转化成Point2d
        /// Translate normal point to 2d point
        /// </summary>
        /// <returns>转化后的Point2d 2d point which has been translated
        /// </returns>
        PointF[] _convertPoint2Point2D () {
            PointF[] points2d = new PointF[4];
            for (int i = 0; i < 4; i++) {
                points2d[i] = new PointF(this.points[i].X, this.points[i].Y);
            }
            return points2d;
        }
        /// <summary>
        /// 得到旋转矩阵，需要使用opencv
        /// </summary>
        void _computeHomographyOpencv () {
            PointF[] src = {
                new PointF (-1, -1),
                new PointF (1, -1),
                new PointF (1, 1),
                new PointF (-1, 1)
            };

            PointF[] dst = _convertPoint2Point2D ();
            Mat retval = CvInvoke.FindHomography(src, dst);
            this.homography = retval;
        }
        /// <summary>
        /// 得到旋转矩阵，不使用opencv
        /// get homography but not using opencv
        /// </summary>
        void _computeHomography () { }
        public void addPoint (Point[] points) {
            this.points = points;
            _computeHomographyOpencv ();
        }
    }
}