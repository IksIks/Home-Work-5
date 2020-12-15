using System;
using System.Linq;


namespace Text_in_word
{

    public class Program
    {
        /// <summary>
        /// Поиск минимального по длине слова
        /// </summary>
        /// <param name="text"> принимаемаемая фраза </param>
        /// <returns> строка содержащая слово минимальной длины </returns>
        static string WordMin(string text)
        {
            string[] word = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string min = word[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Length < min.Length)  min = word[i];
            }
            return min;
        }

        public static void Main()
        {
            string s = WordMin("А ББ ВВВ ГГГГ ДДДД ДД ЕЕ ХХ ЗЗЗ");
            Console.Write(s);
            Console.ReadKey();
        }
    }
}