// Заполнить спирально массив 4х4

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

int[,] GetSpiralFilling(int[,] array)
{
    bool needMoveRigth = true;    // Логические переменные отвечают за направление движения.
    bool needMoveDown = false;
    bool needMoveLeft = false;
    bool needMoveUp = false;

    int linePosition = 0;  // Задают позиционирование внутри массива.
    int columnPosition = 0;

    int minLineIndex = 0;   // Задают область массива, в рамках которой допустимо двигаться.
    int maxLineIndex = 3;
    int minColumnIndex = 0;
    int maxColumnIndex = 3;

    for (int operationsCount = 1; operationsCount <= 16; operationsCount++)
    {

        array[linePosition, columnPosition] = operationsCount;
        if (needMoveRigth == true && columnPosition < maxColumnIndex)
        {
            columnPosition++;
            continue;
        }
        if (needMoveRigth == true && columnPosition == maxColumnIndex)
        {
            needMoveRigth = false;
            needMoveDown = true;
            linePosition++;
            minLineIndex++;
            continue;
        }
        if (needMoveDown == true && linePosition < maxLineIndex && linePosition >= minLineIndex)
        {
            linePosition++;
            continue;
        }
        if (needMoveDown == true && linePosition == maxLineIndex)
        {
            needMoveDown = false;
            needMoveLeft = true;
            columnPosition--;
            maxColumnIndex--;
            continue;
        }
        if (needMoveLeft == true && columnPosition > minColumnIndex)
        {
            columnPosition--;
            continue;
        }
        if (needMoveLeft == true && columnPosition == minColumnIndex)
        {
            needMoveLeft = false;
            needMoveUp = true;
            linePosition--;
            maxLineIndex--;
            continue;
        }
        if (needMoveUp == true && linePosition > minLineIndex)
        {
            linePosition--;
            continue;
        }
        if (needMoveUp == true && linePosition == minLineIndex)
        {
            needMoveUp = false;
            needMoveRigth = true;
            columnPosition++;
            minColumnIndex++;
            continue;
        }

    }
    return array;
}



int[,] newArray = new int[4, 4];
GetSpiralFilling(newArray);
int[,] filledArray = GetSpiralFilling(newArray);
ArrayOutput(filledArray);

