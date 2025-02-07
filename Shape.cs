public abstract class Shape
{
    public abstract double Area {get; set;}

    protected abstract double GetArea();
}

public class Circle : Shape 
{
    public double Radius { get; set; }
    public override double Area { get; set; }

    public Circle(double radius)
    {
        Radius = radius;

        Area = GetArea();
    }

    protected override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;

        Area = GetArea();
    }
    protected override double GetArea()
    {
        return Width * Height;
    }
}