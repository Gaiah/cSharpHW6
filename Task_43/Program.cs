// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Input point b1: ");
double pointB1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Input point b2: ");
double pointB2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Input point k1: ");
double pointK1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Input point k2: ");
double pointK2 = int.Parse(Console.ReadLine() ?? "0");

if (pointK1 == pointK2)
{
    Console.WriteLine("These two straight lines are parallel or coincident");
}
else 
{
    double x = (pointB1 - pointB2)/(pointK2 - pointK1);
    double y = (pointK2*pointB1-pointK1*pointB2)/(pointK2-pointK1);
    Console.WriteLine($"Intersection coordinates of two lines: {x}; {y}");
}