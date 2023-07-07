// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

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

void ColumnArithmeticMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); ++j)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            sum += matrix[i,j];
        }
        double result = sum/matrix.GetLength(0);
        Console.Write($"{result:f1} | ");
    }
}

int rows = 3; 
int columns = 3;
int[,] MyMatrix = GetRandomArray(rows, columns);
PrintMatrixInts (MyMatrix);
ColumnArithmeticMean (MyMatrix);