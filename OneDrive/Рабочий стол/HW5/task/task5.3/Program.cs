/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int Prompt(string massage)
{
    System.Console.Write($"{massage}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int X)
{
    int[] array = new int[X];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
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

int X = Prompt("Размер массива");
int[] array = CreateArray(X);
ShowArray(array);
int MaxNun(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
           max = array[i];
        }

    }
    return max;

}
int MinNun(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
           min = array[i];
        }

    }
    return min;

}
int result = MaxNun(array)-MinNun(array);
Console.WriteLine($"максимальный элемент массива: {MaxNun(array)}");
Console.WriteLine($"минимальный элемент массива: {MinNun(array)}");
Console.WriteLine($"разница между максимальным и минимальным элементом массива: {result}");

