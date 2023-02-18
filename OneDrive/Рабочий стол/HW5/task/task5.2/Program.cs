/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] CreateArray(int len = 4)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]};");
    }

}
int SumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }

    }
    return sum;
}
int[] array = CreateArray();
ShowArray(array);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях: {SumEven(array)}");

