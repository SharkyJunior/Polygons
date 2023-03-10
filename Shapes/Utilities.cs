using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Xml.Schema;

namespace Shapes
{
    static internal class Utilities
    {
        #region Formulas

        static public double ToRadians(int degrees)
        {
            return degrees * Math.PI / 180;
        }

        static public double DistanceBetweenPoints(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2));
        }

        static public double HeronFormula(double sideLength1, double sideLength2, double sideLength3)
        {
            //half the perimeter (for heron formula)
            double s = (sideLength1 + sideLength2 + sideLength3) / 2;

            //heron formula: Sqrt(s * (s - a) * (s - b) * (s - c))
            return Math.Sqrt(s * (s - sideLength1) * (s - sideLength2) * (s - sideLength3));
        }

        #endregion

        #region Grahan Scan

        static public List<Point> ConvertShapesToPoints(List<Shape> shapes)
        {
            List<Point> output = new List<Point>();
            foreach (Shape shape in shapes)
                output.Add(new Point(shape.X, shape.Y));
            return output;
        }

        static public List<Shape> GrahamScan(ref List<Shape> points)
        {
            List<Shape> convexHull = new List<Shape>();
            points = SortShapes(points);

            for (int i = 0; i < points.Count; i++)
            {
                while (convexHull.Count >= 2 && Orientation(convexHull[convexHull.Count - 2], convexHull[convexHull.Count - 1], points[i]) != 1)
                    convexHull.Remove(convexHull.Last());
                convexHull.Add(points[i]);
            }
            points = convexHull;
            return convexHull;
        }

        static public List<Shape> GrahamScan(List<Shape> points)
        {
            List<Shape> convexHull = new List<Shape>();
            points = SortShapes(points);

            for (int i = 0; i < points.Count; i++)
            {
                while (convexHull.Count >= 2 && Orientation(convexHull[convexHull.Count - 2], convexHull[convexHull.Count - 1], points[i]) != 1)
                    convexHull.Remove(convexHull.Last());
                convexHull.Add(points[i]);
            }
            return convexHull;
        }

        // to determine starting point of a Graham scan
        static private Shape FindGreatestY(List<Shape> shapes)
        {
            return new List<Shape>(shapes.OrderBy(shape => -shape.Y).ThenByDescending(shape => shape.X))[0];
        }

        //sorting all the points by angle between horizontal line through greatest Y point and point. (counter clockwise)
        static private List<Shape> SortShapes(List<Shape> shapes)
        {
            Shape greatestYshape = FindGreatestY(shapes);

            //sorting firstly by polar angle (relative to greatest Y point) counter-clockwise, then by distance between points (if points are collinear)
            return new List<Shape>(shapes.OrderBy(shape => -Math.Atan2(greatestYshape.Y - shape.Y, greatestYshape.X - shape.X)).ThenByDescending(shape => DistanceBetweenPoints(shape.X, shape.Y, greatestYshape.X, greatestYshape.Y)).ToList()); 
        }

        static private int Orientation(Shape pointBeforeLast, Shape lastPoint, Shape nextPoint)
        {
            double area = (lastPoint.X - pointBeforeLast.X) * (nextPoint.Y - pointBeforeLast.Y) - (lastPoint.Y - pointBeforeLast.Y) * (nextPoint.X - pointBeforeLast.X);

            if (area < 0) return 1; //counter-clockwise
            if (area > 0) return -1; //clockwise
            return 0; //collinear
        }

        #endregion

        #region Line Scan Convex Hull

        public static void DrawConvexHullByDef(Graphics g, Color linesColor, List<Shape> shapes)
        {
            LineFunction lineFunc;

            int minX = shapes[0].X, maxX = shapes[0].X;
            foreach (Shape shape in shapes)
            {
                if (minX > shape.X)
                    minX = shape.X;
                if (maxX < shape.X)
                    maxX = shape.X;
            }

            for (int i = 0; i < shapes.Count; i++)
            {
                for (int n = i + 1; n < shapes.Count; n++)
                {
                    lineFunc = new LineFunction(shapes[i].X, shapes[i].Y, shapes[n].X, shapes[n].Y);
                    int aboveCount = 0, belowCount = 0;
                    bool lineInHull = true;
                    bool equalX = false;
                    if (shapes[i].X == shapes[n].X)
                        equalX = true;
                    foreach (Shape shape in shapes)
                    {
                        if (shape != shapes[i] && shape != shapes[n])
                        {
                            var newY = lineFunc.k * shape.X + lineFunc.b;
                            
                            if (newY > shape.Y)
                                belowCount++;
                            else if (newY < shape.Y)
                                aboveCount++;

                            if ((aboveCount > 0 && belowCount > 0) || (equalX && shapes[i].X != minX && shapes[i].X != maxX))
                            {
                                lineInHull = false;
                                break;
                            }
                            
                        }
                    }

                    if (lineInHull)
                    {
                        g.DrawLine(new Pen(linesColor, 2), shapes[i].X, shapes[i].Y, shapes[n].X, shapes[n].Y);
                   
                    }
                }

            }
        }
        #endregion 

        // for getting rid of unnecessary references
        public static List<Shape> CopyFrom(List<Shape> shapes)
        {
            var copied = new List<Shape>();
            foreach (Shape shape in shapes)
            {
                copied.Add(shape.Copy());
            }
            return copied;
        }

        public static Color CopyColor(Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        protected struct LineFunction
        {
            public double k, b;

            LineFunction(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public LineFunction(int x1, int y1, int x2, int y2)
            {
                this.k = (double)(y2 - y1) / (double)(x2 - x1);
                this.b = y1 - k * x1;
            }
        }
    }
}

