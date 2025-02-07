using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Площадь круга: {circle.Area}");

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
    }
}
