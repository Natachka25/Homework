// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3 

Console.WriteLine("Введите количество чисел: ");

int numberCount = int.Parse(Console.ReadLine()!);

Console.WriteLine(CountPositiveNumberFromConsole(numberCount));

int CountPositiveNumberFromConsole(int numberCount)
{
    int counter = 0;
    for (int i = 0; i < numberCount; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine()!);

        if (IsPositive(currentNumber))
        {
            counter++;
        }
    }
    return counter;
}
bool IsPositive(int number)
{
    if (number > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}