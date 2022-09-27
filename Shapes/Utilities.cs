using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    static internal class Utilities
    {
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

        static public List<Point> ConvertShapesToPoints(List<Shape> shapes)
        {
            List<Point> output = new List<Point>();
            foreach (Shape shape in shapes)
                output.Add(new Point(shape.X, shape.Y));
            return output;
        }
        static public List<Point> GrahamScan(List<Point> points)
        {
            List<Point> convexHullPoints = new List<Point>();
            Point startingPoint = FindGreatestY(points);
            points = SortPoints(points);
            bool done = false;
            bool ccw = false;
            int counter = 0;

            convexHullPoints.Add(startingPoint);
            
            /*
            while (!ccw)
            {
                if (CounterClockwise(startingPoint, points[0], p))
            }
            Point probablePoint = points[1];
            while (!done)
            {
                while (!ccw)
                {
                    counter++;
                    if (CounterClockwise())
                }
            }
            */
        }

        static private Point FindGreatestY(List<Point> points)
        {
            Point output = points[0];
            foreach (Point point in points)
            {
                if (point.Y > output.Y)
                    output = point;
            }
            return output;
        }

        //sorting all the points by angle between horizontal line through greatest Y point and point. (counter clockwise)
        static private List<Point> SortPoints(List<Point> points)
        {
            Point greatestYpoint = FindGreatestY(points);
            points.Remove(greatestYpoint);
            return new List<Point>(points.OrderBy(point => -Math.Atan2(greatestYpoint.Y - point.Y, greatestYpoint.X - point.X)).ToList()); 
        }

        static private int CounterClockwise(Point pointBeforeLast, Point lastPoint, Point nextPoint)
        {
            double area = (lastPoint.X - pointBeforeLast.X) * (nextPoint.Y - pointBeforeLast.Y) - (lastPoint.Y - pointBeforeLast.Y) * (nextPoint.X - pointBeforeLast.X);

            if (area < 0) return -1;
            if (area > 0) return 1;
            return 0;
        }
    }
}
