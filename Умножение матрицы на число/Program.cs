using System;

namespace Matrix_operation
{

    public class Matrix_operation
    {
        static bool ConditionalTest(bool condition, ref int n)
        {
            while (!condition || n < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Вводите только числа(положительные): ");
                Console.ResetColor();
                condition = int.TryParse(Console.ReadLine(), out n);
            }
            return condition;
        }
        static bool ConditionalTest(bool condition)
        {
            while (!condition)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Вводите только числа(положительные): ");
                Console.ResetColor();
                condition = int.TryParse(Console.ReadLine(), out n);
            }
            return condition;
        }
        static int[,] Multiplication(int[,] matrix, int number)
        {
            int[,] mult = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Console.WriteLine("\nРезультат умножения\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mult[i, j] = matrix[i, j] * number;
                }
            }
            return mult;
        }
        static void PrintResult(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],2} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Main()
        {
            Random r = new Random();
            int n = 0;
            int row = 0;
            int col = 0;
            bool success;
            string s = String.Empty;
            for (int i = 0; i < 2; i++)
            {
                s = (i == 0) ? "строк" : "столбцов";

                Console.Write($"Введите количество {s} матрицы ");
                success = int.TryParse(Console.ReadLine(), out n);
                success = ConditionalTest(success, ref n);
                
                if (i == 0)
                {
                    row = n;
                }
                else col = n;
            }

            int[,] a = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = r.Next(1, 10);
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите множитель");
            success = int.TryParse(Console.ReadLine(), out n);
            while (!success)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вводите только целые числа: ");
                Console.ResetColor();
                success = int.TryParse(Console.ReadLine(), out n);
            }
            a = Multiplication(a, n);
            PrintResult(a);            
        }
    }
}