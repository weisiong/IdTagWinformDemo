using System;
using System.Collections;
using OpenCvSharp;

namespace csharp {
    public class Apriltag 
        {
        Tagfamilies tagfamily; // Tag family
        string threshold;      // Method to threshold the picture (adaptive or canny)
        bool   debug;
        string familyname;     // TagFamily's name
        double sigma;          // Sigma you want to blur the picture
        int    nthread;
        int    minarea;        // Quad's min area
        
        /// <summary>
        /// apriltag class 
        /// </summary>
        /// <param name="threshold"> Edege detection method </param>
        /// <param name="debug"> Debug or not (e.g., Display process step by step) </param>
        /// <param name="familyname"> Name of tag family，tag36h11 is set as default </param>
        /// <param name="sigma"> The sigma value of Gaussian Blur </param>
        /// <param name="nthread"> How many threads are currently not supported </param>
        /// <param name="minarea"> Minimun area of detection </param>
        /// 
        public Apriltag (string threshold = "canny", bool debug = false, string familyname = "tag36h11", double sigma = 0.8, int nthread = 1, int minarea = 400)
        {
            this.threshold  = threshold;
            this.debug      = debug;
            this.familyname = familyname;
            this.sigma      = sigma;
            this.nthread    = nthread;
            this.minarea    = minarea;

            switch (familyname) 
            {
                case "tag36h11":
                    this.tagfamily = new Tag36h11class ();
                    break;
                case "tag25h9":
                    this.tagfamily = new Tag25h9class ();
                    break;
                case "tag16h5":
                    this.tagfamily = new Tag16h5class ();
                    break;
                default:
                    this.tagfamily = new Tag36h11class ();
                    break;
            }
        }
        
        /// <summary>
        /// Perform point mapping, and map the native points into thier four corresponding points in p
        /// </summary>
        /// <param name="p"> Quads </param>
        /// <param name="relativePoint"> Points to be mapped </param>
        /// <returns> Mapped point </returns>
        Point _interpolate (Point[] p, Point2d relativePoint)
        {
            double tmp0 = p[1].X * p[2].Y;
            double tmp1 = p[2].X * p[1].Y;
            double tmp2 = tmp0 - tmp1;
            double tmp3 = p[1].X * p[3].Y;
            double tmp4 = tmp2 - tmp3;
            double tmp5 = p[3].X * p[1].Y;
            double tmp6 = p[2].X * p[3].Y;
            double tmp7 = p[3].X * p[2].Y;
            double tmp8 = tmp4 + tmp5 + tmp6 - tmp7;
            double tmp9 = p[0].X * p[2].X;
            double tmp10 = tmp9 * p[1].Y;
            double tmp11 = p[1].X * p[2].X;
            double tmp12 = p[0].X * p[3].X;
            double tmp13 = p[1].X * p[3].X;
            double tmp14 = tmp13 * p[0].Y;
            double tmp15 = tmp9 * p[3].Y;
            double tmp16 = tmp13 * p[2].Y;
            double tmp17 = tmp10 - tmp11 * p[0].Y - tmp12 * p[1].Y + tmp14 - tmp15 + tmp12 * p[2].Y + tmp11 * p[3].Y - tmp16;
            double tmp18 = p[0].X * p[1].X;
            double tmp19 = p[2].X * p[3].X;
            double tmp20 = tmp18 * p[2].Y - tmp10 - tmp18 * p[3].Y + tmp14 + tmp15 - tmp19 * p[0].Y - tmp16 + tmp19 * p[1].Y;
            double tmp21 = p[0].X * p[1].Y;
            double tmp22 = p[1].X * p[0].Y;
            double tmp23 = tmp22 * p[2].Y;
            double tmp24 = tmp21 * p[3].Y;
            double tmp25 = p[2].X * p[0].Y;
            double tmp26 = p[3].X * p[0].Y;
            double tmp27 = tmp26 * p[2].Y;
            double tmp28 = tmp1 * p[3].Y;
            double tmp29 = tmp21 * p[2].Y - tmp23 - tmp24 + tmp22 * p[3].Y - tmp25 * p[3].Y + tmp27 + tmp28 - tmp5 * p[
                2].Y;
            double tmp30 = p[0].X * p[2].Y;
            double tmp31 = tmp23 - tmp25 * p[1].Y - tmp24 + tmp26 * p[1].Y + tmp30 * p[3].Y - tmp27 - tmp0 * p[
                3].Y + tmp28;
            double tmp32 = p[0].X * p[3].Y;
            double tmp33 = tmp30 - tmp25 - tmp32 - tmp0 + tmp1 + tmp26 + tmp3 - tmp5;
            double tmp34 = tmp21 - tmp22;
            double tmp35 = tmp34 - tmp30 + tmp25 + tmp3 - tmp5 - tmp6 + tmp7;
            double hx = (tmp17 / tmp8) * relativePoint.X - (tmp20 / tmp8) * relativePoint.Y + p[0].X;
            double hy = (tmp29 / tmp8) * relativePoint.X - (tmp31 / tmp8) * relativePoint.Y + p[0].Y;
            double hw = (tmp33 / tmp8) * relativePoint.X + (tmp35 / tmp8) * relativePoint.Y + 1;
            return new Point (hy / hw, hx / hw);
        }

        /// <summary>
        /// Get average point
        /// </summary>
        /// <param name="list"> ArrayList of Int32 </param>
        /// <returns> Mapped points </returns>
        double _average (ArrayList list)
        {
            int sum = 0;
            foreach (byte item in list) {
                sum += item;
            }
            return sum / list.Count;
        }

        /// <summary>
        /// Detect one frame
        /// </summary>
        /// <param name="frame"> A RGB picture</param>
        /// <returns> Results of detections (ArrayList) </returns>
        public ArrayList detect (Mat frame) 
        {
            Mat gray  = new Mat ();
            Mat dst   = new Mat ();
            Mat gauss = new Mat ();
            Cv2.CvtColor (frame, gray, ColorConversionCodes.RGB2GRAY);
            Cv2.GaussianBlur (gray, gauss, new Size (3, 3), this.sigma);

            switch (this.threshold)
            {
                case "canny":
                    Cv2.Canny (gauss, dst, 150, 400, 3);
                    break;
                case "adaptive":
                    Cv2.AdaptiveThreshold (gauss, dst, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.BinaryInv, 9, 5);
                    break;
                default:
                    Cv2.Canny (gauss, dst, 150, 400, 3);
                    break;
            }

            Point[][] contours;
            HierarchyIndex[] hierarchy;
            Cv2.FindContours (dst, out contours, out hierarchy, OpenCvSharp.RetrievalModes.CComp, ContourApproximationModes.ApproxSimple, null);
            if (this.debug == true) 
            {
                Mat copyimg = new Mat ();
                frame.CopyTo (copyimg);
                copyimg.DrawContours (contours, -1, new Scalar (0, 255, 0));
                using (new Window ("contours image", copyimg)) 
                {
                    Cv2.WaitKey ();
                }
                copyimg.Dispose();
            }

            ArrayList hulls = new ArrayList ();
            ArrayList quads = new ArrayList ();
            for (int i = 0; i < contours.Length; i++) 
            {
                var contour = contours[i]; // Get polygon
                if (contour.Length >= 4 && hierarchy[i].Previous < 0) 
                {
                    var area = Cv2.ContourArea (contour); // Get contour's area
                    if (area > this.minarea) 
                    {
                        var hull = Cv2.ConvexHull (contour); // Get hull
                        if ((area / Cv2.ContourArea (hull)) > 0.8) 
                        {
                            hulls.Add (hull);
                            var quad = Cv2.ApproxPolyDP (hull, 9, true); // Get quad (Calculate quadrilateral from convex hull)
                            if (quad.Length == 4) 
                            {
                                var areaqued = Cv2.ContourArea (quad);
                                var areahull = Cv2.ContourArea (hull);
                                if (areaqued / areahull > 0.8 && areahull >= areaqued)
                                {
                                    quads.Add (quad);
                                }
                            }
                        }
                    }
                }
            }
            if (this.debug == true) 
            {
                Mat copyimg = new Mat ();
                frame.CopyTo (copyimg);
                foreach (Point[] item in quads) {
                    Point[][] temp = new Point[1][];
                    temp[0] = item;
                    copyimg.DrawContours (temp, -1, new Scalar (0, 255, 0));
                }
                using (new Window ("contours image", copyimg))
                {
                    Cv2.WaitKey ();
                }
                Console.WriteLine ("quads count" + quads.Count);
                copyimg.Dispose();
            }

            ArrayList detections  = new ArrayList ();
            ArrayList points      = new ArrayList ();
            ArrayList whitepoints = new ArrayList ();

            // Extract the quad point
            foreach (Point[] quad in quads) 
            {
                int dd = this.tagfamily.getBlackBorder () * 2 + this.tagfamily.getEdge ();
                ArrayList blackvalue = new ArrayList ();
                ArrayList whitevalue = new ArrayList ();

                for (int iy = 0; iy < dd; iy++) 
                {  
                   for (int ix = 0; ix < dd; ix++)
                   {
                        double x = (ix + 0.5) / (dd * 1.0);
                        double y = (iy + 0.5) / (dd * 1.0);
                        var polatepoint = _interpolate (quad, new Point2d (x, y));
                        points.Add (polatepoint);
                        var value = gray.At<byte> (polatepoint.X, polatepoint.Y);
                        if ((iy == 0 || iy == dd - 1) || (ix == 0 || ix == dd - 1))
                        {
                            blackvalue.Add (value);
                        }
                        else if ((iy == 1 || iy == dd - 2) || (ix == 1 || ix == dd - 2)) 
                        {
                            whitevalue.Add (value);
                        }
                        else 
                        {
                            continue;
                        }
                   }
                }

                long tagcode  = 0;
                var threshold = 0.5 * (_average (blackvalue) + _average (whitevalue));
                for (int iy = 0; iy < dd; iy++) 
                {
                    for (int ix = 0; ix < dd; ix++) 
                    {
                        if ((iy == 0 || iy == dd - 1) || (ix == 0 || ix == dd - 1)) 
                        {
                            continue;
                        }
                        double newx = (ix + 0.5) / dd * 1.0;
                        double newy = (iy + 0.5) / dd * 1.0;
                        Point point = _interpolate (quad, new Point2d (newx, newy));
                        int grayvalue = gray.At<byte> (point.X, point.Y);
                        tagcode = tagcode << 1;
                        if (grayvalue > threshold)
                        {
                            tagcode |= 1;
                            whitepoints.Add (point);
                        }
                    }
                }

                TagDetection decoderesult = this.tagfamily._decode (tagcode);
                if (decoderesult.good == true) 
                {
                    decoderesult.addPoint (quad);
                    detections.Add (decoderesult);
                }
            }
            if (this.debug == true) 
            {
                Mat copyimg = new Mat ();
                frame.CopyTo (copyimg);
                foreach (Point item in points)
                {
                    Point tpoint = new Point (item.Y, item.X);
                    copyimg.Circle (tpoint, 1, new Scalar (0, 0, 255));
                }
                using (new Window ("quad", copyimg))
                {
                    Cv2.WaitKey ();
                }

                Mat copyimg2 = new Mat ();
                frame.CopyTo (copyimg2);
                foreach (Point item in whitepoints)
                {
                    Point tpoint = new Point (item.Y, item.X);
                    copyimg2.Circle (tpoint, 1, new Scalar (0, 0, 255));
                }
                using (new Window ("quad", copyimg2))
                {
                    Cv2.WaitKey ();
                }

                copyimg.Dispose();
                copyimg2.Dispose();
            }

            // Huu Duoc inputs the disposal of mat objects
            gray.Dispose();
            dst.Dispose();
            gauss.Dispose();

            return detections;
        }
    }
}