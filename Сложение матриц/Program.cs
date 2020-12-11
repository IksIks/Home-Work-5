using System;

namespace Matrix_operation
{

    public class Matrix_operation
    {
        static int[,] BuildingMatrix()
        {
            int row = 0;
            int col = 0;
            int n = 0;
            for (int i = 0; i < 2; i++)
            {
                string s = (i == 0) ? "строк" : "столбцов";
                Console.Write($"Введите количество {s} матрицы: ");
                bool success = int.TryParse(Console.ReadLine(), out n);
                while (!success || n < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Вводите только числа(положительные): ");
                    Console.ResetColor();
                    success = int.TryParse(Console.ReadLine(), out n);
                }
                if (i == 0)
                {
                    row = n;
                }
                else col = n;
            }
            int[,] matrix = new int[row, col];
            return matrix;
        }
        static int[,] AdditionOfMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] summ = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    summ[i, j] = matrix1[i, j] + matrix2[i, j];                    
                }                
            }
            return summ;
        }
        static void Main()
        {
                Console.WriteLine("Матрица 'A'\n");
                int[,] a = BuildingMatrix();
                Console.WriteLine("\nМатрица 'B'\n");
                int[,] b = BuildingMatrix();
            while (true)
            {
                if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Колличество строк и столбцов матрицы 'A' должно соответствовать" +
                                        " матрице 'B'. Что то пошло не так, повторите ввод");
                    Console.ResetColor();
                    Console.WriteLine("Матрица 'A'\n");
                    a = BuildingMatrix();
                    Console.WriteLine("\nМатрица 'B'\n");
                    b = BuildingMatrix();
                }
                else break;
            }
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(1, 10);
                    Console.Write($"{a[i, j]} ");
                }                
                Console.Write("      ");
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = r.Next(1, 10);
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            int[,] result = AdditionOfMatrices(a, b);
            Console.WriteLine("\nСумма двух матриц");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j],2}  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}