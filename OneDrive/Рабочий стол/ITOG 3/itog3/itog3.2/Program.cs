/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсия!

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
   return SumNumbers(numberM + 1)+numberM;
    
}
System.Console.Write(SumNumbers(1,15));