using System;

namespace EasyShapes.Shapes
{
    internal struct Triangle
    {
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be greater than zero.");

            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("The sum of any two sides must be greater than the third side.");

            A = a;
            B = b;
            C = c;
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public double GetArea()
        {
            var p = (A + B + C) / 2d;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRightTriangle()
        {
            var sides = new double[] { A, B, C };
            Array.Sort(sides);

            var g = sides[2];   // Гипотенуза
            var c1 = sides[1];  // Катет 1
            var c2 = sides[0];  // Катет 2

            return g * g == c1 * c1 + c2 * c2;
        }
    }
}
