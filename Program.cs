using System;
using System.Collections.Generic;

namespace FindingPi
{
    internal class Program
    {
        static Vector2 centerCoordinates = new Vector2(.5, .5);
        static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                int pointCount;


                Console.WriteLine("Point count. The more, the merrier. *recommended 5 digit min");
                while (true)
                {
                    try
                    {
                        pointCount = int.Parse(Console.ReadLine());
                        if (pointCount < 1000) Console.WriteLine("WARNING!!! Point count too low, may cause incorrect results :)");
                        else if (pointCount > 99999999)
                            throw new OverflowException();
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid format");
                        continue;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Number too big. Try again. Input 8 digit number max :)");
                        continue;
                    }
                }
                Vector2[] planePoints = new Vector2[pointCount];
                List<Vector2> cornerPoints = new List<Vector2>();

                for (int i = 0; i < pointCount; i++)
                {
                    Vector2 point = GetRandomVector2();
                    planePoints[i] = point;
                    if (point.Distance(centerCoordinates) > .5)
                        cornerPoints.Add(point);
                }

                Console.WriteLine($"Pi: {Pi(pointCount, cornerPoints.Count)}");

                Console.WriteLine("\nPress any key to continue...");
                Console.WriteLine("or Escape to close. \n");

                planePoints = null;
                cornerPoints = null;
               
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        public static Vector2 GetRandomVector2()
        {
            double vecX = random.NextDouble(); 
            double vecY = random.NextDouble(); 

            return new Vector2(vecX, vecY);
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
