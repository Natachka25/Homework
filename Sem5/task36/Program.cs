// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()!);

int[] array = CreateArray(arrayLength, 0, 100);
PrintArray(array);
int oddCount = SumOddPosition(array);
Console.WriteLine(oddCount);

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
         sum+= array[i];
    }
    return sum;
}