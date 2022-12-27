public abstract class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get; }
}

public class Square : Shape
{
    public Square(double length)
    {
        this.Width = length;
        this.Height = length;
    }
    public new double Area => Math.Pow(Width, 2);
}
public class Circle : Shape
{
    public double radius { get; set; }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public new double Area => Math.PI * Math.Pow(radius, 2);
}

public class Rectangle : Shape
{
    public Rectangle(int height, double width)
    {
        Height = height;
        Width = width;
    }

    public new double Area => Height * Width;
}