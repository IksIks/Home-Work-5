using System;

namespace Progression
{
    class Program
    {
        /// <summary>
        /// Определение типа прогрессии
        /// </summary>
        /// <param name="numbers"></param>
        static void Progression(params int[] numbers)
        {
            if (numbers.Length >= 3)
            {
                int dArithmetic = numbers[1] - numbers[0];
                bool Arithmetic = true;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1] + dArithmetic)
                    {
                        Arithmetic = true;
                    }
                    else
                    {
                        Arithmetic = false;
                        break;
                    }
                }
                int dGeometric = 0;
                bool Geometric = true;
                if (numbers[0] != 0 && numbers[1] != 0)
                {
                    dGeometric = numbers[1] / numbers[0];                   
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] == numbers[i - 1] * dGeometric)
                        {
                            Geometric = true;
                        }
                        else
                        {
                            Geometric = false;
                            break;
                        }
                    }
                }
                else Geometric = false;

                if (Arithmetic == true && Geometric == true) Console.WriteLine("Это геометрическая прогрессия" +
                                                                " со знаменателем 1 или арифметическая прогрессия с разностью 0)");
                else if (Geometric) Console.WriteLine("Это геометрическая прогрессия");
                else if (Arithmetic) Console.WriteLine("Это арифметическая прогрессия");
                else
                {
                    Console.WriteLine("Это набор цифр");
                }
            }
            else Console.WriteLine("Нужно минимум 3 цифры");
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, };
            Progression(array);
            Console.ReadKey();
        }
    }
}
