// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1 || m < 1) 
{
    Console.WriteLine("М и N должны быть больше нуля");
}

else if (n < m)
{
    Console.WriteLine("М должно быть меньше N");
}
else
{
    Console.WriteLine(SumNatNumberRec(m, n, 0));
}

int SumNatNumberRec(int num1, int num2, int sum) 
{
    if (num1 > num2) 
    {
        return sum;
    }
    sum += num1;
    return SumNatNumberRec(num1 + 1, num2, sum);
}