using System;
using System.Linq;

namespace Slow_Word
{
	class Program
	{
		/// <summary>
		/// преобразует слово в символы и удаляет повторящиеся второй и последующие символы
		/// </summary>
		/// <param name="slowWord"> преобразуемая фраза </param>
		/// <returns> возвращает фразу без повторяющихся символов </returns>
		static string Word(string slowWord)
		{
			char[] letters = slowWord.ToCharArray();
			char[] phrase = new char[letters.Length];
			int j = 0;
			phrase[0] = letters[0];

			for (int i = 1; i < letters.Length; i++)
			{
				if (letters[i] != phrase[j])
				{
					j++;
					phrase[j] = letters[i];
				}
			}

			string s = new string(phrase, 0, j + 1); // создает новую строку размером j + 1, заполняя от нулевой позиции
			return s;
		}
		static void Main(string[] args)
		{

			string s = Word(("пппппппррриииИИИивввееееееттттт        ввввсссссееееммммм уууучччащщщщиммммссссяяяяя").ToLower());
			Console.Write(s);
			Console.ReadKey();
		}
	}
}
