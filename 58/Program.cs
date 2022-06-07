// Задать две матрицы.
// Произвести умножение матриц.

int[,] FillArray(int[,] array)
{
    Random values = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = values.Next(1, 11);
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



int[,] MultiplyTables(int[,] array1, int[,] array2)
// resultArray - получаемая матрица
// resultArrayI, resultArrayJ - переменные, хранящие текущие индексы получаемой матрицы
// resultValue - сохраняет сумму необходимых произведений для присваивания элементам получаемой матрицы
// numberOperations - счетчик пар операций умножение-суммирование для сбора значений в resultValue
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int resultArrayI = 0; resultArrayI < resultArray.GetLength(0); resultArrayI++)
    {
        for (int resultArrayJ = 0; resultArrayJ < resultArray.GetLength(1); resultArrayJ++)
        {
            int resultValue = 0;
            for (int numberOperations = 0; numberOperations < array1.GetLength(1); numberOperations++)
            {
                resultValue += array1[resultArrayI, numberOperations] * array2[numberOperations, resultArrayJ];
            }
            resultArray[resultArrayI, resultArrayJ] = resultValue;
        }
    }
    return resultArray;
}

// array1Dimentions, array2Dimentions - массивы, хранящие параметры перемножаемых матриц
// firstTable, secondTable - полученные перемножаемые массивы
Console.Write("Введите размерность первой матрицы через пробел: ");
int[] array1Dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write("Введите размерность второй матрицы через пробел: ");
int[] array2Dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[,] firstTable = new int[array1Dimentions[0], array1Dimentions[1]];
int[,] secondTable = new int[array2Dimentions[0], array2Dimentions[1]];

Console.WriteLine("Первая матрица: ");
FillArray(firstTable);
ArrayOutput(firstTable);
Console.WriteLine("Вторая матрица: ");
FillArray(secondTable);
ArrayOutput(secondTable);
Console.WriteLine();
if (array1Dimentions[1] == array2Dimentions[0])
{
    int[,] multipliedTable = MultiplyTables(firstTable, secondTable);
    Console.WriteLine("Результат умножения: ");
    ArrayOutput(multipliedTable);
}
else Console.WriteLine("Данные матрицы нельзя перемножить. Количество столбцов первой матрицы должно быть равно количеству строк второй.");
