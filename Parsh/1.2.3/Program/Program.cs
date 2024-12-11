using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите пять чисел через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 5 || 
            !int.TryParse(input[0], out int num1) || 
            !int.TryParse(input[1], out int num2) || 
            !int.TryParse(input[2], out int num3) || 
            !int.TryParse(input[3], out int num4) || 
            !int.TryParse(input[4], out int num5))
        {
            Console.WriteLine("Ошибка: Введите ровно пять корректных чисел.");
            return;
        }

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сумма чисел");
        Console.WriteLine("2 - Максимум из чисел");
        Console.WriteLine("3 - Минимум из чисел");
        Console.WriteLine("4 - Произведение чисел");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Ошибка: Выберите корректный номер операции.");
            return;
        }

        switch (choice)
        {
            case 1:
                int sum = num1 + num2 + num3 + num4 + num5;
                Console.WriteLine($"Сумма чисел: {sum}");
                break;

            case 2:
                int max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
                Console.WriteLine($"Максимум: {max}");
                break;

            case 3:
                int min = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));
                Console.WriteLine($"Минимум: {min}");
                break;

            case 4:
                long product = (long)num1 * num2 * num3 * num4 * num5;
                Console.WriteLine($"Произведение чисел: {product}");
                break;

            default:
                Console.WriteLine("Ошибка: Выберите номер операции от 1 до 4.");
                break;
        }
    }
}
