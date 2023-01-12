// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите число m: ");
int mInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int nInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min: ");
int minInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max: ");
int maxInput = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateMatrix(mInput, nInput, minInput, maxInput);

PrintMatrix(matrix);
Console.WriteLine();
System.Console.WriteLine();
PrintMatrix(SortMatrix(matrix));

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

int[,] SortMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int t = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = t;
                }
            }
        }
    }

    return array;

}