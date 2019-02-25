using System;
using System.Linq;

namespace SRM_332_DivII_250
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStatistics test = new TextStatistics();
            Console.WriteLine(test.averageLength("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
        }
    }

    class TextStatistics
    {
        public double averageLength(String text)
        {
            char[] delimeters = new char[] { ',', '.', '?', '!', '-', ' ' };
            int eachWordCount = 0;
            int totalTextCount = 0;
            int noOfWordsInText = 0;
            text = text.ToLower();
            if (text == "")
                return 0;
            text += ' ';
            for (int i = 0; i < text.Length; i++)
            {

                if (delimeters.Contains(text[i]) || (text[i] <= 'a' && text[i] >= 'z')) // word has finished
                {
                    totalTextCount += eachWordCount;
                    if (eachWordCount != 0)
                    {
                        noOfWordsInText++;
                    }
                    eachWordCount = 0;
                }
                else//still in a word
                {
                    eachWordCount++;
                }
            }
            return totalTextCount / (noOfWordsInText * 1.0);
        }
    }
}
