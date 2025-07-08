var shapes = new IShape[]
{
	new Circle(2.0),
	new Rectangle(3.0, 4.0),
	new Triangle(3.0, 4.0)
};

foreach (var shape in shapes)
{
	Console.WriteLine($"Area: {shape.Area()}");
}

public interface IShape
{
	double Area();
}

public class Circle : IShape
{
	private double radius;

	public Circle (double radius) { this.radius = radius; }

	public double Area() => Math.PI * radius * radius;
}

public class Rectangle : IShape
{
	private double width, height;

	public Rectangle (double width, double height)
	{
		this.width = width;
		this.height = height;
	}
	
	public double Area() => width * height;
}

public class Triangle : IShape
{
	private double baseline, height;

	public Triangle (double @base, double height)
	{
		this.baseline = @base;
		this.height = height;
	}

	public double Area() => 0.5 * baseline * height;
}
