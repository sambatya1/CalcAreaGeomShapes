namespace CalcArea;
public interface IShape
{
    double GetArea();
}
public class Circle : IShape
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
public class Triangle : IShape
{
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

// рассчитаем площадь треугольника по форуле Герона 
    public double GetArea()
    {
        double s = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
    }  
}
