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
        return Math.Round(Math.PI * _radius * _radius,4);
    }
    public override string ToString()
    {
        return _radius.ToString();
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
    // Проверка треугольника на прямоугольность
    public bool IsRightAngled()
    {
        double[] sides = new double[] { _side1, _side2, _side3 };
        Array.Sort(sides);
        return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
    }

    public override string ToString()
    {
        return $"a={_side1},b={_side2},c={_side3}";
    }
}
