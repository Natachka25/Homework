// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1 || m < 1) 
{
    Console.WriteLine("М и N должны быть больше нуля");
}
else
{
    Console.WriteLine(CalcAck(m, n));
}

int CalcAck(int n, int m)
{
   if (n == 0)
   {
     return m + 1;
   }
   else if (m == 0)
   {
     return CalcAck (n - 1, 1);
   }
   else
   {
     return CalcAck(n - 1, CalcAck (n, m - 1));
   }
}