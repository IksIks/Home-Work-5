using System;

namespace Функция_Аккермана
{
    class Program
    {
        static int Akkerman(int n, int m)
        {
            if (n == 0) return m + 1;
            else if (m == 0 && n != 0) return Akkerman(n - 1, 1);
            else return Akkerman(n - 1, Akkerman(n, m - 1));            
        }
        static void Main(string[] args)
        {
            int n = 0, m = 0;            
            for (int i = 1; i <= 2; i++)
            {                
                Console.Write($"Введите {i} число ");                
                bool result = int.TryParse(Console.ReadLine(), out int number);
                while (!result || number < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Вводите только числа(положительные): ");
                    Console.ResetColor();
                    result = int.TryParse(Console.ReadLine(), out number);
                }
                if (i == 1)
                {
                    n = number;
                }
                else m = number;
            }                       
            Console.WriteLine($"Значение функции Аккермана равно {Akkerman(n, m)}");
            Console.ReadKey();
        }
    }
}
