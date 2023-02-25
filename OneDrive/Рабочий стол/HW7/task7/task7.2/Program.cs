/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет
1, 1 -> 1*/

int Promt(string massage)
{
    System.Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int m = 0; m < array.GetLength(0); m++)
    {

        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{

    for (int m = 0; m < array.GetLength(0); m++)
    {
        System.Console.WriteLine();
        for (int n = 0; n < array.GetLength(1); n++)
        {
            System.Console.Write($"{array[m, n]}\t");
        }
    }
    System.Console.WriteLine();
}
int FindIndex(int[,] array, int num1, int num2)
{
    if (num1 < 0 || num2 < 0 || num1 > array.GetLength(0)-1 || num2 > array.GetLength(1)-1)
    {
        
            System.Console.WriteLine("Вы вышли за пределы массива");
            return 0;
    }
    return array[num1, num2];
}
int row = Promt("Введите количество строк: ");
int col = Promt("Введите количество столбцов: ");
int[,] array = GenerateArray(row, col);
PrintArray(array);
System.Console.WriteLine();
int num1 = Promt("Введите индекс строки: ");
int num2 = Promt("Введите индекс столбца: ");
System.Console.WriteLine(FindIndex(array, num1, num2));


