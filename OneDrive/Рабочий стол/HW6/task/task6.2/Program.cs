/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double Prompt(string massage)
{
    System.Console.Write($"{massage}: ");
    double result = Convert.ToInt32(Console.ReadLine());
    return result;
}
(double, double) Point (double b1, double b2, double k1, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    return (x,y);
}
double b1 = Prompt("Введите число b1: ");
double b2 = Prompt("Введите число b2: ");
double k1 = Prompt("Введите число k1: ");
double k2 = Prompt("Введите число k2: ");
(double x, double y) = Point(b1, b2, k1, k2);
Console.Write($"Прямые пересекаются в точке: ({x},{y})");

