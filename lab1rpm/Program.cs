using System;

public abstract class Triangle
{
    protected double side1;
    protected double side2;
    protected double angle;

    public Triangle(double side1, double side2, double angle)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.angle = angle;
    }

    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}

public class RightTriangle : Triangle
{
    public RightTriangle(double side1, double side2, double angle)
        : base(side1, side2, angle)
    {
    }

    public override double CalculateArea()
    {
        return 0.5 * side1 * side2;
    }

    public override double CalculatePerimeter()
    {
        double side3 = Math.Sqrt(side1 * side1 + side2 * side2);
        return side1 + side2 + side3;
    }
}

public class IsoscelesTriangle : Triangle
{
    public IsoscelesTriangle(double side1, double side2, double angle)
        : base(side1, side2, angle)
    {
    }

    public override double CalculateArea()
    {
        double height = side2 * Math.Sin(angle);
        return 0.5 * side1 * height;
    }

    public override double CalculatePerimeter()
    {
        double side3 = side1;
        return side1 + side2 + side3;
    }
}

public class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double side, double angle)
        : base(side, side, angle)
    {
    }

    public override double CalculateArea()
    {
        double height = side1 * Math.Sin(angle);
        return 0.5 * side1 * height;
    }

    public override double CalculatePerimeter()
    {
        double side3 = side1;
        return 3 * side1;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Triangle rightTriangle = new RightTriangle(3, 4, Math.PI / 2);
        Console.Write("Прямоугольный треугольник: ");
        Console.Write("Площадь: " + rightTriangle.CalculateArea() + " ");
        Console.WriteLine("Периметр: " + rightTriangle.CalculatePerimeter());

        Triangle isoscelesTriangle = new IsoscelesTriangle(5, 5, Math.PI / 3);
        Console.Write("Равнобедренный треугольник: ");
        Console.Write("Площадь: " + isoscelesTriangle.CalculateArea() + " ");
        Console.WriteLine("Периметр: " + isoscelesTriangle.CalculatePerimeter());

        Triangle equilateralTriangle = new EquilateralTriangle(6, Math.PI / 3);
        Console.Write("Равносторонний треугольник: ");
        Console.Write("Площадь: " + equilateralTriangle.CalculateArea() + " ");
        Console.WriteLine("Периметр: " + equilateralTriangle.CalculatePerimeter());
    }
}
