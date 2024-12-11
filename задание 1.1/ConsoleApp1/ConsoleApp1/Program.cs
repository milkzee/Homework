using System;

class Program
{
    static void DetermineSeason()
    {
        Console.Write("Введите номер месяца: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int month))
        {
            Console.WriteLine("Это не число");
            return;
        }

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Это не номер месяца");
        }
        else if (month == 12 || month == 1 || month == 2)
        {
            Console.WriteLine("Зима");
        }
        else if (month >= 3 && month <= 5)
        {
            Console.WriteLine("Весна");
        }
        else if (month >= 6 && month <= 8)
        {
            Console.WriteLine("Лето");
        }
        else if (month >= 9 && month <= 11)
        {
            Console.WriteLine("Осень");
        }
    }

    static void Main(string[] args)
    {
        DetermineSeason();
    }
}
