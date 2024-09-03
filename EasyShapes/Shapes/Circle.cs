using System;

namespace EasyShapes.Shapes
{
    internal struct Circle
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");

            Radius = radius;
        }

        public double Radius { get; private set; }

        public double GetArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
