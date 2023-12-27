using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        PrintNumbersInRange(m, n);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbersInRange(start + 1, end);
        }
    }
}