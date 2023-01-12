// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите число m: ");
int mInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int nInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min: ");
int minInput = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max: ");
int maxInput = int.Parse(Console.ReadLine()!);
Console.WriteLine();
double[,] arrayUser = CreateMatrix(mInput, nInput, minInput, maxInput);
PrintMatrix(arrayUser);
Console.WriteLine();
Console.WriteLine(SmallestString(arrayUser));

double[,] CreateMatrix(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((max - min) * new Random().NextDouble() + min, 2);
        }
    }
    return array;
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
double SmallestString(double[,] array)
{
    double[] sumString = new double[array.GetLength(0)];
    double min = double.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString[i] += array[i, j];
            if (i == 0)
                min = sumString[i];
        }
        if (sumString[i] < min)
            min = sumString[i];
    }
    return min;
}