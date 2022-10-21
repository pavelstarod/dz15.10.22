// Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы 


double k1=1;
double b1=7;
double k2=4;
double b2=6;

double x=(b2-b1)/(k1-k2);
double y=k2*x+b2;

Console.WriteLine($"Вывод координат пересечения: x = {x}    y = {y}");
