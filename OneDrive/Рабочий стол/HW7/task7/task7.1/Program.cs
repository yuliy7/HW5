/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

double[,] GenerateArray(int row, int col)
{
  double[,] array = new double[row,col];
  Random rnd = new Random();
  for (int m = 0; m < array.GetLength(0); m++)
  {
    for (int n = 0; n < array.GetLength(1); n++)
    {
        array[m,n] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
    }
  }  
  return array;
}

void PrintArray(double[,] array)
{
  
    for (int m = 0; m < array.GetLength(0); m++)
    {
         System.Console.WriteLine();
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if(array[m,n]%1 == 0)System.Console.Write($"{array[m,n]:f0}\t");
            else System.Console.Write($"{array[m,n]:f1}\t");
        }
    }
     System.Console.WriteLine();
}

double[,] array = GenerateArray(3,4);
PrintArray(array);


