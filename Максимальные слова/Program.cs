using System;


namespace TextMax
{
    class Program
    {
        /// <summary>
        /// Поиск максимально длинного слова из массива сслов
        /// </summary>
        /// <param name="text"> текст переданный на обработку </param>
        /// <returns> возвращет массив из максимальных слов. Возврат зависит от функции "WordSearch" </returns>
        static string[] WordMax(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string max = words[0];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max.Length)
                {
                    max = words[i];
                }
            }
            string[] maxWords = WordSearch(words, max);

            return maxWords;
        }
        /// <summary>
        /// Поиск слов схожих по длинне с найденным максимальным словом в методе WordMax
        /// </summary>
        /// <param name="words"> массив слов </param>
        /// <param name="max"> маскимальное по длине слово </param>
        /// <returns></returns>

        static string[] WordSearch(string[] words, string max)
        {
            string[] maxWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max.Length)
                {
                    maxWords[i] = words[i];
                }
            }
            return maxWords;
        }

        static void Main(string[] args)
        {
            string[] maxWords = WordMax("А ББ ВВВ ГГГГ ДДДД ДД ЕЕ ХХ ЗЗЗ");
            for (int i = 0; i < maxWords.Length; i++)
            {
                if (maxWords[i] != null)
                {
                    Console.Write($"{maxWords[i]} ");
                }
            }
            Console.ReadKey();
        }
    }
}
