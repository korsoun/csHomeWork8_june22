// Сформировать трехмерный массив из неповторяющихся двухзначных чисел.
// Построчно вывести его, указывая при этом его индексы.

int[,,] FillArray(int[,,] array)
{
    int positionValue = 11;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = positionValue;
                positionValue++;
            }
        }
    }
    return array;
}

void ThreeDimArrayOutput(int[,,] array)
{
    Console.WriteLine("|{0,8}|{1,8}|", "Индексы", "Элемент");
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                Console.WriteLine("|{0, 8}|{1,8}|", (i + "; " + j + "; " + k), array[i, j, k]);
                count++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Random arrayDimentions = new Random();
int[,,] array = new int[arrayDimentions.Next(2,6),arrayDimentions.Next(2,6),arrayDimentions.Next(2,6)];
Console.WriteLine($"Создан трехмерный массив размерами {array.GetLength(0)}x{array.GetLength(1)}x{array.GetLength(2)}.");
FillArray(array);
Console.WriteLine("Список его элементов: ");
ThreeDimArrayOutput(array);