// Задать прямоугольный двумерный массив.
// Найти строку с наименьшей суммой элементов.

int[,] FillArray(int[,] array)
{
    Random values = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = values.Next(1, 21);
        }
    }
    return array;
}

void ArrayOutput(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

void GetTheLightestLine(int[,] array)
{
    int minimalSum = 0;
    int minimalLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minimalSum += array[0, j];
    }
    Console.WriteLine($"Сумма 1-й строки равна {minimalSum}.");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int lineSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineSum += array[i, j];
        }
        if (lineSum < minimalSum)
        {
            minimalSum = lineSum;
            minimalLine = i;
        }
        Console.WriteLine($"Сумма {i+1}-й строки равна {lineSum}.");
    }
    Console.WriteLine($"Минимальная сумма в {minimalLine+1}-й строке.");
}

int[,] newArray = new int[5,3];
FillArray(newArray);
ArrayOutput(newArray);
Console.WriteLine();
GetTheLightestLine(newArray);