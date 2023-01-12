// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

PrintMatrix(CreateSpiralMatrix(a, b));

int[,] CreateSpiralMatrix(int m, int n)
{
    int value = 1;
    int[,] matrix = new int[m, n];
    int i = 0;
    int j = 0;
    int k = matrix.GetLength(0) - 1;
    int z = matrix.GetLength(1) - 1;
    int cycle = 0;
    while (value <= m * n)
    {
        if (j < matrix.GetLength(1) - cycle - 1)
        {
            matrix[i, j] = value++;
            j++;
        }
        else if (i < matrix.GetLength(0) - cycle - 1)
        {
            matrix[i, j] = value++;
            i++;
        }
        else if (z > cycle)
        {
            matrix[k, z] = value++;
            z--;
        }
        else if (k > cycle)
        {
            matrix[k, z] = value++;
            k--;
        }
        else
        {
            cycle++;
            i = cycle;
            j = cycle;
            k = matrix.GetLength(0) - cycle - 1;
            z = matrix.GetLength(1) - cycle - 1;

            if (m * n - value == 0)
            {
                matrix[i, j] = value++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{PrintValue(inArray[i, j])} ");
        }
        Console.WriteLine();
    }
}

string PrintValue(int value)
{
    if (value < 10)
    {
        return "0" + value;
    }
    else
    {
        return "" + value;
    }
}
