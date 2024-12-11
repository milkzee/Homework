using System;

class Program
{
    static void Main()
    {
        // Переменные для чисел
        int a = 0, b = 0, c = 0;

        // Чтение и проверка первого числа
        Console.WriteLine("Введите первое число:");
        if (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Некорректный ввод! Установлено значение 0.");
        }

        // Чтение и проверка второго числа
        Console.WriteLine("Введите второе число:");
        if (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Некорректный ввод! Установлено значение 0.");
        }

        // Чтение и проверка третьего числа
        Console.WriteLine("Введите третье число:");
        if (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Некорректный ввод! Установлено значение 0.");
        }

        // Сумма положительных чисел
        int sum = 0;

        if (a > 0)
        {
            sum += a;
        }
        if (b > 0)
        {
            sum += b;
        }
        if (c > 0)
        {
            sum += c;
        }

        // Вывод результата
        Console.WriteLine("Сумма положительных чисел: " + sum);
    }
}
