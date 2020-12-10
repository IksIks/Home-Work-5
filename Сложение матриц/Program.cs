using System;

namespace Matrix_operation
{

    public class Matrix_operation
    {
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
            Random r = new Random();
            char index = new char();
            int rowA = 0;
            int colA = 0;
            int rowB = 0;
            int colB = 0;
            int rowCol = 0; // общая переменная для строк и столбцов обеих матриц
            while (true)
            {
                for (int i = 0; i < 2; i++)
                {
                    index = (i == 0) ? 'A' : 'B';
                    for (int j = 0; j < 2; j++)
                    {
                        string s = (j == 0) ? "строк" : "столбцов";
                        Console.Write($"Введите количество {s} матрицы {index}: ");
                        bool success = int.TryParse(Console.ReadLine(), out rowCol);
                        while (!success || rowCol < 0)
                        {
                            Console.Write($"Вводите только числа(положительные): ");
                            success = int.TryParse(Console.ReadLine(), out rowCol);
                        }
                        if (index == 'A')
                        {
                            if (j == 0) rowA = rowCol;
                            else colA = rowCol;
                        }
                        else
                        {
                            if (j == 0) rowB = rowCol;
                            else colB = rowCol;
                        }
                    }
                }
                if (rowA != rowB || colA != colB)
                    Console.WriteLine("Колличество строк и столбцов матрицы 'A' должно соответствовать" +
                                      " матрице 'B'. Что то пошло не так, повторите ввод");
                else break;
            }
            int[,] a = new int[rowA, colA], b = new int[rowA, colA], result = new int[rowA, colA];
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    a[i, j] = r.Next(1, 10);
                    Console.Write($"{a[i, j]} ");
                }
                Console.Write("      ");
                for (int j = 0; j < colA; j++)
                {
                    b[i, j] = r.Next(1, 10);
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            result = AdditionOfMatrices(a, b);
            Console.WriteLine("\nСумма двух матриц");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j],2} ");
                }
                Console.WriteLine();
            }
        }
    }
}