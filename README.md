# CalcAreaGeomShapes 
Библиотека CalcArea.dll умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
Рассчитанные площади округляются до 4 знаков после запятой.
Для использования библиотеки поместите её в каталог вашего проекта и сделайте ссылку на неё.
Важно: для работы библиотеки необходима платформа .Net 7.

Пример использования библиотеки:

    using CalcArea;
    
    Circle c = new Circle(10);
    Console.WriteLine($"Площадь круга с радиусом {c.ToString()} = {c.GetArea()}");
    
    Triangle t = new Triangle(3,4,6);
    Console.WriteLine($"Площадь треугольника со сторонами {t.ToString()} составляет {t.GetArea()}");
    
    var s = t.IsRightAngled()?"прямоугольным.":"не прямоугольным.";
    Console.WriteLine($"Треугольник со сторонами {t.ToString()} является {s}");
      
    // Выходные данные
    Площадь круга с радиусом 10 = 314,1593
    Площадь треугольника со сторонами a=3,b=4,c=6 составляет 5,3327
    Треугольник со сторонами a=3,b=4,c=6 является не прямоугольным.
  
