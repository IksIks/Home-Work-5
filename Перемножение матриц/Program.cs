using System;


namespace Matrix_Multiplication
{
    class Program
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
                    Console.Write($"Вводите только числа(положительные): ");
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
        static void FillingMatrices(ref int[,] matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }                    
                }               
            }
            return result;
        }
        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица 'A'\n");
            int[,] a = BuildingMatrix();
            Console.WriteLine("\nМатрица 'B'\n");
            int[,] b = BuildingMatrix();
            
            while (true)
            {
                if (a.GetLength(1) != b.GetLength(0))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Колличество СТОЛБЦОВ матрицы 'A' должно соответствовать" +
                                      " колличеству СТРОК матрицы 'B'. Повторите ввод\n");
                    Console.ResetColor();
                    Console.WriteLine("Матрица 'A'\n");
                    a = BuildingMatrix();
                    Console.WriteLine("\nМатрица 'B'\n");
                    b = BuildingMatrix();
                }
                else break;
            }
            FillingMatrices(ref a);
            Console.WriteLine();
            FillingMatrices(ref b);
            a = MatrixMultiplication(a, b);
            Console.WriteLine("Произведение двух матриц равно");
            Print(a);
            Console.ReadKey();

        }
    }
}
