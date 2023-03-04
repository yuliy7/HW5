﻿/* Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

void ShowNumbers(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return;
    }
    if (numberM % 2 == 0)
    {
        return;
    }
    System.Console.Write(numberM + ", ");
    ShowNumbers(numberM + 1, numberN);
}
ShowNumbers(5, 10);