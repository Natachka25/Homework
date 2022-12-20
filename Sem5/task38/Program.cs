// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементоv массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine()!);

double[] array = CreateDoubleArray(arrayLength, min, max);
PrintDobleArray(array);
double result = FindMinMaxDiff(array);
Console.WriteLine(result);

double[] CreateDoubleArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        double number = new Random().NextDouble() * (max - min) + min;
        array[i] = Math.Round(number, 2);
        // array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
    }
    return array;
}

void PrintDobleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindMinMaxDiff(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
}