using System;

namespace AreaLib
{
    public static class Area
    {
        public static double CircleCalculate(double r)
            => r >= 0 ? Math.PI * (r * r) : throw new Exception("ArgumetLessThanZero");

        public static double TriangleCalculate(double a, double b, double c)
        {
            // Check argumets
            if (a <= 0 && b <= 0 && c <= 0)
                throw new Exception("ArgumetLessThanZero");

            // Triangle check onRectangular
            double max = Math.Max(a, Math.Max(b, c));

            if (max == a)
                Console.WriteLine($"onRectangular: {a == Math.Sqrt((b * b) + (c * c))}");
            if (max == b)
                Console.WriteLine($"onRectangular: {b == Math.Sqrt((a * a) + (c * c))}");
            if (max == c)
                Console.WriteLine($"onRectangular: {c == Math.Sqrt((b * b) + (a * a))}");

            // Calculate area
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // Add new method calculate area

        public static double FigureCalculate(double r)
            => CircleCalculate(r);

        public static double FigureCalculate(double a, double b, double c)
            => TriangleCalculate(a, b, c);

        public static double FigureCalculate(double a, double b, double c, double d)
        {
            // Check argumets
            if (a <= 0 && b <= 0 && c <= 0 && d <= 0)
                throw new Exception("ArgumetLessThanZero");

            if (a == c && b == d)
                return a * c;

            if (a == b && c == d)
                return a * b;

            if (b == c && a == d)
                return b * c;

            //TODO

            throw new Exception("CouldNotCalculateArea");
        }

        // Add new method FigureCalculate area
    }
}
