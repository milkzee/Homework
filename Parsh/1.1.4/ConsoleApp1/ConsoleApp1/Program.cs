using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите четырехзначное число: ");
        string number = Console.ReadLine();

        // Проверка, что введено четырехзначное число
        if (number.Length != 4 || !int.TryParse(number, out _))
        {
            Console.WriteLine("Ошибка: введено не четырехзначное число");
        }
        else
        {
            // Извлекаем цифры
            int a = int.Parse(number[0].ToString()); 
            int b = int.Parse(number[1].ToString()); 
            int c = int.Parse(number[2].ToString());
            int d = int.Parse(number[3].ToString()); 

            // Проверка условия задачи
            if (a + d == b - c)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
        }
    }
}
