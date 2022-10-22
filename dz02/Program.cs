//  Написать программу масштабирования фигуры


Console.WriteLine("Введите первой точки: ");
double x1= double.Parse(Console.ReadLine()?? "0");
double y1= double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите второй точки: ");
double x2= double.Parse(Console.ReadLine()?? "0");
double y2= double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите третьей точки: ");
double x3= double.Parse(Console.ReadLine()?? "0");
double y3= double.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите четвертой точки: ");
double x4= double.Parse(Console.ReadLine()?? "0");
double y4= double.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Задайте коэффициент масштабирования: ");
double k= double.Parse(Console.ReadLine()?? "0");

Console.WriteLine("Вывод получившихся коорлдинат: ");
Console.WriteLine($"({x1*k},{y1*k})({x2*k},{y2*k})({x3*k},{y3*k})({x4*k},{y4*k})");