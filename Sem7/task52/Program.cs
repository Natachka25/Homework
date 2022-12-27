Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = CreateMatrix(m, n, -5, 10);

PrintMatrix(matrix);
PrintArray(Average(matrix));

Console.WriteLine("Введите позицию i: ");
int posi = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию j: ");
int posj = int.Parse(Console.ReadLine()!);

Console.WriteLine("Значение элемента: " + matrix[posi, posj]);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
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

double[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
         Console.WriteLine();
    }
    return matrix;
} 

double[] Average(double[,] matrix)
{
    int colunCount = matrix.GetLength(1);
    int rowCount = matrix.GetLength(0);
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < colunCount; j++)
    {
        double sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += matrix[i, j];
        }
        result[j] = Math.Round((double) sum / rowCount, 2);
    }
    return result;
}