using System;

namespace AreaLib
{
    public class AreaClass
    {
        public static double Area(params double[] parameters)
        {
            if (parameters.Length == 1)
            {
                return CircleArea(parameters[0]);
            }
            else if (parameters.Length == 3)
            {
                return TriangleArea(parameters[0], parameters[1], parameters[2]);
            }
            else throw new ArgumentException("Unknown figure");
        }
        public static double TriangleArea(double a, double b, double c)
        {
            if (a > b)
            {
                double t = a;
                a = b;
                b = t;
            }
            if (b > c)
            {
                double t = b;
                b = c;
                c = t;
            }
            if (a > b)
            {
                double t = a;
                a = b;
                b = t;
            }
            bool isCorrectTriangle = a > 0 && b > 0 && c > 0 && a + b > c;
            if (!isCorrectTriangle) throw new ArgumentException("Triangle sides are incorrect");
            bool isRightTriangle = a * a + b * b - c * c < double.Epsilon;
            if (isRightTriangle) return a * b / 2;
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        public static double CircleArea(double r)
        {
            bool isCorrectCircle = r > 0;
            if (!isCorrectCircle) throw new ArgumentException("Circle radius is incorrect");
            return Math.PI * r * r;
        }
    }
}
