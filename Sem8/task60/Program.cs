// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

if (a * b * c > 90)
{
    Console.WriteLine("Слишком большая матрица");
}
else
{
    int[,,] matrix = Create3DMatrix(a, b, c);
    Print3DMatrix(matrix);
    Console.WriteLine();
}

void Print3DMatrix(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("-----------------");
    }
}

int[,,] Create3DMatrix(int a, int b, int c)
{
    int[] range = new int[a * b * c];
    Console.WriteLine($"{a * b * c}");
    for (int i = 0; i < range.Length; i++)
    {
        range[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (range[j] == range[i])
            {
                range[i] = new Random().Next(10, 100);
                for (int k = 0; k < i; k++)
                {
                    if (range[k] == range[i])
                    {
                        j = k;
                        break;
                    }
                }
            }
        }
    }

    int[,,] result = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                result[i, j, k] = range[k + j * c + i * b * c];
            }
        }
    }
    return result;
}
