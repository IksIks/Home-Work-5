using System;
using System.Linq;


namespace TextMax
{
    class Program
    {
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
            string[] maxWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max.Length)
                {
                    maxWords[i] = words[i];
                    //Console.WriteLine(maxWords[i]);
                }
            }
            
            return maxWords;
        }

        static void Main(string[] args)
        {           
           
            string[] words = WordMax("А ББ ВВВ ГГГГ ДДДД ДД ЕЕ ХХ ЗЗЗ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    Console.Write($"{words[i]} ");
                }
            }
            Console.ReadKey();
        }
    }
}
