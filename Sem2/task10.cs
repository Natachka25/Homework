int number = int.Parse(Console.ReadLine()!);

if (number < 0)
{
    number = -number;
}
if (100 <= number && number <= 999)
{
    int secondDigit = number / 10 % 10;

    Console.WriteLine(secondDigit);
}
