// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Например:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(n);
    }
    else
    {
        Console.Write($"{n}, ");
        PrintNumbers(n - 1);
        Console.WriteLine();
    }
}