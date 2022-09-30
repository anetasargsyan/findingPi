using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FindingPi
{
    internal class FindingPi
    {
        static Vector2 centerCoordinates = new Vector2(.5, .5);
        static Random random = new Random();
        int pointCount;
        static void Main(string[] args)
        {
            MainForm mainForm = new MainForm();
            Application.Run(mainForm);

            //mainForm.OnSubmit += VisualizePoints;            
        }
        public static Vector2 GetRandomVector2()
        {
            double vecX = random.NextDouble(); 
            double vecY = random.NextDouble(); 

            return new Vector2(vecX, vecY);
        }


        public static double VisualizePoints(int pointCount)
        {
            Vector2[] planePoints = new Vector2[pointCount];
            List<Vector2> cornerPoints = new List<Vector2>();

            for (int i = 0; i < pointCount; i++)
            {
                Vector2 point = GetRandomVector2();
                planePoints[i] = point;
                if (point.Distance(centerCoordinates) > .5)
                    cornerPoints.Add(point);
            }

            //Pi(pointCount, cornerPoints.Count);

            double pi = 0;
            double circleArea = 1 - ((double)cornerPoints.Count/(double)pointCount );
            //Console.Write(circleArea);
            pi = circleArea / .25;


            planePoints = null;
            cornerPoints = null;
            return pi;
        }
        public static double Pi(int pointCount, int cornerPointsCount)
        {


            double pi = 0;
            double circleArea = 1 - ((double)cornerPointsCount / (double)pointCount);
            //Console.Write(circleArea);
            pi = circleArea / .25;

            return pi;
        }
    }

    public struct Vector2
    {
        public double x;
        public double y;

        public Vector2(double a, double b)
        {
            x = a;
            y = b;
        }
        public double Distance(Vector2 c2)
        {
            double distance;
            distance = Math.Sqrt((c2.x - x) * (c2.x - x) + (c2.y - y) * (c2.y - y));
            return Math.Abs(distance);
        }

        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
}
