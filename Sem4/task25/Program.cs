 // 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A = ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B = ");
int numB = int.Parse(Console.ReadLine()!);


int Function = Power(numA, numB);
Console.WriteLine(Function);


int Power(int numberA, int numberB)
{
    if (numberB < 0)
    {
        numberB = -numberB;
    }
    int AinB = numberA;
    for (int i = 1; i < numberB; i++)
    {
        AinB = AinB * numberA;
    }
    return AinB;
}