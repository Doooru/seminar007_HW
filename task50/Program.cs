// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2



int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    return matrix;
}

void PrintMatrixInts(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void RequestNumberFromArray (int iPosition, int jPosition, int[,] MyMatrix)
{
    if (iPosition <= MyMatrix.GetLength(0)-1)
    {
        if (jPosition <= MyMatrix.GetLength(1)-1)
        {
            Console.Write($"нужное вам число {MyMatrix[iPosition,jPosition]}");
        }
        else
        {
            Console.Write("такого столбца в массиве нет");
        }
    }
    else
    {
        Console.Write("такой строки в массиве нет");
    }
}

int rows = 5; 
int columns = 5;
Console.Write("введите номер в строке: ");
int iPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбика: ");
int jPosition = Convert.ToInt32(Console.ReadLine());
int[,] MyMatrix = GetRandomArray(rows, columns);
PrintMatrixInts (MyMatrix);
RequestNumberFromArray (iPosition,jPosition, MyMatrix);