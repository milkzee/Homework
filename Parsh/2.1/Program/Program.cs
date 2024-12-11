using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три числа через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 3 || 
            !int.TryParse(input[0], out int a) || 
            !int.TryParse(input[1], out int b) || 
            !int.TryParse(input[2], out int c))
        {
            Console.WriteLine("Ошибка: Введите три корректных числа.");
            return;
        }

        int diff1 = b - a; // Разность между вторым и первым
        int diff2 = c - b; // Разность между третьим и вторым

        string result = diff1 == diff2 ? "YES" : "NO";

        switch (result)
        {
            case "YES":
                Console.WriteLine("YES");
                break;

            case "NO":
                Console.WriteLine("NO");
                break;

            default:
                Console.WriteLine("Произошла ошибка.");
                break;
        }
    }
}
