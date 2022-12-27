// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = CreateMatrix(m, n, -5, 10);

PrintMatrix(matrix);
Console.WriteLine("Введите позицию i: ");
int posi = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию j: ");
int posj = int.Parse(Console.ReadLine()!);

if (matrix.GetLength(0) < posi || matrix.GetLength(1) < posj)
{
    Console.WriteLine("такого элемента не существует");
}
else
{
    Console.WriteLine("Значение элемента: " + matrix[posi, posj]);
}

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
            matrix[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    Console.WriteLine();
    return matrix;
}