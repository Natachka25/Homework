int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number;
}

if (number < 100)
{
    Console.WriteLine("3-й цифры нет");
}
else
{
    while (number > 999)
    {
        number = number /10;
    }
    int thirdDigit = number % 10;
    
    Console.WriteLine(thirdDigit);
}
