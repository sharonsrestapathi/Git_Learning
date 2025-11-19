using OOPS_CONCEPT.Models;

class Program
{
    static void Main()
    {
        Shape circle = new Circle("Red", 5);
        circle.ShowColor();
        Console.WriteLine("Circle Area: " + circle.CalculateArea());

        Shape rectangle = new Rectangle("Blue", 4, 6);
        rectangle.ShowColor();
        Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

        Shape triangle = new Triangle("Green", 10, 5);
        triangle.ShowColor();
        Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
    }
}