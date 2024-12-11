using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите шестизначное число:");
            string input = Console.ReadLine();

            if (input.Length == 6 && int.TryParse(input, out _))
            {
                string result = input[5].ToString() + input[4] + input.Substring(2, 2) + input[1] + input[0];
                Console.WriteLine($"Результат: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: необходимо ввести ровно шестизначное число.");
            }
        }
    }
}
