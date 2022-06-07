// Дополнительно
// Вывести первые N строк треугольника Паскаля в виде равнобедренного треугольника

string[,] GetPascalTriangle(int n)
{
    int[,] numberArray = new int[n, 2 * n - 1];
    string[,] stringArray = new string[n, 2 * n - 1];

    numberArray[0, numberArray.GetLength(1) / 2] = 1;
    if (n == 2)
    {
        numberArray[1, 0] = 1;
        numberArray[1, 2] = 1;
    }

    if (n > 2)
    {
        numberArray[1, (numberArray.GetLength(1) / 2) - 1] = 1;
        numberArray[1, (numberArray.GetLength(1) / 2) + 1] = 1;
        for (int i = 2; i < n; i++)
        {
            numberArray[i, (numberArray.GetLength(1) / 2) - i] = 1;
            numberArray[i, (numberArray.GetLength(1) / 2) + i] = 1;
            int startingPosForFill = (numberArray.GetLength(1) / 2) - i + 2;
            
            for (int j = startingPosForFill; j < (numberArray.GetLength(1) / 2) + i; j = j + 2)
            {
                numberArray[i, j] = numberArray[i - 1, j - 1] + numberArray[i - 1, j + 1];
            }
        }
    }
    for (int i = 0; i < stringArray.GetLength(0); i++)
    {
        for (int j = 0; j < stringArray.GetLength(1); j++)
        {
            stringArray[i, j] = Convert.ToString(numberArray[i, j]);
            if (stringArray[i, j] == "0")
            {
                stringArray[i, j] = string.Empty;
            }
        }
    }
        return stringArray;
}

void ArrayOutput(string[,] array)
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

Console.WriteLine("Сколько вывести строк? ");
int lineQuantity = Convert.ToInt32(Console.ReadLine());

string[,] result = GetPascalTriangle(lineQuantity);
ArrayOutput(result);
