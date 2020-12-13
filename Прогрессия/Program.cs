using System;

namespace Progression
{
	class Program
	{
		static void Progression(params int[] numbers)
		{
			int dArithmetic = numbers[1] - numbers[0];
			int dGeometric = numbers[1] / numbers[0];
			bool Arithmetic = true;
			bool Geometric = true;
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

			if (Arithmetic) Console.WriteLine("Это арифметическая прогрессия");
			else if (Geometric) Console.WriteLine("Это геометрическая прогрессия");
			else
			{
				Console.WriteLine("Это набор цифр");
			}

		}
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 4, 8, 16, 32};
			Progression(array);
			Console.ReadKey();
		}
	}
}
