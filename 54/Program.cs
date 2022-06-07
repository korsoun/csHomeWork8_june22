// Задать двумерный массив.
// Упорядочить элементы в каждой строке по убыванию

int[,] FillArray(int[,] array)
{
    Random values = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = values.Next(1, 51);
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

int[,] SortingLines(int[,] array)
{
    int[,] resultArray = array;
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1)-1; j++)
        {
            int temp = 0;
            int max = resultArray[i, j];
            for (int k = j + 1; k < resultArray.GetLength(1); k++)
            {
                if (resultArray[i, k] > max)
                {
                    max = resultArray[i,k];
                    temp = resultArray[i, k];
                    resultArray[i, k] = resultArray[i, j];
                    resultArray[i, j] = temp;
                }
            }
        }
    }
    return resultArray;
}

int[,] array = new int[3, 4];
FillArray(array);
ArrayOutput(array);
Console.WriteLine();
int[,] sortingArray = SortingLines(array);
ArrayOutput(sortingArray);

