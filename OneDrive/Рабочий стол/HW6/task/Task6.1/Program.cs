/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int Prompt(string massage)
{
    System.Console.Write($"{massage}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите число {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine()!);
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

int Positive(int[] num)
{
    int Positive = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            Positive++;
        }

    }

    return Positive;
}

int Length = Prompt($"Введите размер массива");
int[] array = CreateArray(Length);
ShowArray(array);
int PCount = Positive(array);
Console.WriteLine($"Количество чисел больше 0: {PCount}");


