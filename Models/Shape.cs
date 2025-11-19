using System;

namespace OOPS_CONCEPT.Models
{
    public abstract class Shape
    {
        // Encapsulation with protected field and public property
        private string _color=null!;

        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Color cannot be empty");
                _color = value;
            }
        }

        // Constructor
        public Shape(string color)
        {
            Color = color;
        }

        // Abstract method → must be implemented by all shapes
        public abstract double CalculateArea();

        // Normal method → shared functionality
        public void ShowColor()
        {
            Console.WriteLine($"Shape color is: {Color}");
        }
    }
}