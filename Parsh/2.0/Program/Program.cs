using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три числа через пробел:");
        string input = Console.ReadLine();
        
        // Разделение строки на массив строк и преобразование в числа
        string[] parts = input.Split(' ');

        if (parts.Length != 3)
        {
            Console.WriteLine("Пожалуйста, введите ровно три числа.");
            return;
        }

        // Парсинг чисел
        try
        {
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);

            // Проверка условия арифметической прогрессии
            if ((b - a) == (c - b))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введите только числовые значения.");
        }
    }
}