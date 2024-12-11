using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Ошибка: Введено не число.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Ошибка: Введено не число.");
            return;
        }

        Console.WriteLine("Выберите операцию (+, -, *, /):");
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: Деление на ноль.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция. Выберите из (+, -, *, /).");
                break;
        }
    }
}
