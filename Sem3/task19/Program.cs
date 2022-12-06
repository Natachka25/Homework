Console.WriteLine("Введите пятизначное число:");
string array = Console.ReadLine()!;

int i = 0;

if (array[0] == '-') i = 1;

if (array[i] == array[4 + i] && array[1 + i] == array[3 + i])
{
    Console.WriteLine("Число является палиндроном");
}
else
{
    Console.WriteLine("Число не является палиндроном");
}

// Вариант решения для любого числа:

Console.WriteLine("Введите число:");
string array = Console.ReadLine()!;

int size = array.Length;
int i = 0;

if (array[0] == '-') i = 1;

bool result = true;
while (i < size/2)
{
    if (array[i] != array[size - 1 - i]) 
    {
        result = false;
        break;
    }
    i++;
}

if (result == true) 
{
    System.Console.WriteLine("Палиндром");
} 
else 
{
    System.Console.WriteLine("Не палиндром");
}
