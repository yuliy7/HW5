/*Задача 3. Задайте двумерный массив из целых чисел. Н
айдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
void FindArithmeticMean(int[,] array, int row, int col )
{
   for (int n = 0; n < col; n++)
    {
        double sum = 0;
         for (int m = 0; m < row; m++)
        {
           sum += array[m,n];
        }
        double mean = sum / row;
       System.Console.Write($"{mean:f1}\t");
       
    }
    
}
int row = Promt("Введите количество строк: ");
int col = Promt("Введите количество столбцов: ");
int[,] array = GenerateArray(row, col);
PrintArray(array);
FindArithmeticMean(array, row, col);
System.Console.WriteLine();
