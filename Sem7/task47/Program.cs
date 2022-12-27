// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = CreateMatrix(m, n, -5, 10);

PrintMatrix(matrix);

void PrintMatrix(double[,] inArray)
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

double[,] CreateMatrix(int m, int n, double min, double max)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    Console.WriteLine();
    return matrix;
} 