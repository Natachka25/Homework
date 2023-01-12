// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число m: ");
int mInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int nInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min: ");
int minInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max: ");
int maxInput = int.Parse(Console.ReadLine()!);

int[,] matrix1 = CreateMatrix(mInput, nInput, minInput, maxInput);
int[,] matrix2 = CreateMatrix(nInput, mInput, minInput, maxInput);

PrintMatrix(matrix1);
Console.WriteLine();

PrintMatrix(matrix2);
Console.WriteLine();

PrintMatrix(MultiplyMatrixes(matrix1, matrix2));

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    Console.WriteLine();
    return matrix;
}

void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;

}