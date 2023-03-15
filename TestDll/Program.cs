using CalcArea;

Circle c = new Circle(10);
Console.WriteLine($"Площадь круга с радиусом {c.ToString()} = {c.GetArea()}");

Triangle t = new Triangle(3,4,6);
Console.WriteLine($"Площадь треугольника со сторонами {t.ToString()} составляет {t.GetArea()}");

var s = t.IsRightAngled()?"прямоугольным.":"не прямоугольным.";
Console.WriteLine($"Треугольник со сторонами {t.ToString()} является {s}");


