using System;

namespace OOPS_CONCEPT.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        // Polymorphism → different formula
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}