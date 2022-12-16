// Напишите программу, которая принимает на вход числа n, min, max.
// Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число n");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число min");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число max ");
int max = int.Parse(Console.ReadLine()!);

int[] array = GenArray(num, min, max);

for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

int[] GenArray(int n, int min, int max)
{
   int[] array = new int[n];
   for (int i = 0; i < array.Length; i++)
    {
     array[i] = new Random().Next(min, max + 1);
    }
    return array;
}  