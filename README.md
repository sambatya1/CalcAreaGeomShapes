# CalcAreaGeomShapes 
Библиотека CalcArea.dll умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Для использования библиотеки поместите её в каталог вашего проекта и сделайте ссылку на неё.
Важно: для работы библиотеки необходима платформа .Net 7.

Пример использования библиотеки:

using CalcArea;

Circle c = new Circle(3.14);
Console.WriteLine($"Площадь круга = {c.GetArea()}");

Triangle t = new Triangle(14,35,23);
Console.WriteLine($"Площадь треугольника = {t.GetArea()}");