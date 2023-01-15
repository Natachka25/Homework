// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1)
{
        Console.WriteLine("Введите число больше единицы");
}
else
{
    PrintNatNumberRec(n);
}

void PrintNatNumberRec(int num) 
{
    if (num < 1) 
    {
        return;
    }

    Console.Write($"{num} ");
    PrintNatNumberRec(num - 1);
}