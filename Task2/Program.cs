// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите размер массив m x n:");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
double[,] arr = new double[m, n];
Console.Write("Исходный массив:\n");
FillArray(arr);
PrintArray(arr);
int pos1 = inputNumber("Введите строку: ") - 1;
int pos2 = inputNumber("Введите столбец: ") - 1;
SearchElement(pos1,pos2);
Console.WriteLine();

void SearchElement(int line, int column)
{
    if (line < 0 | line > arr.GetLength(0) - 1 | column < 0 | column > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[line, column]);
    }
}

int inputNumber(string message)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine()!;
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}

void FillArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 2);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}