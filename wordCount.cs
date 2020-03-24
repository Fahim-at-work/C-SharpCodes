using System;

namespace Assignment
{
    class Program
    {

        static void wordsCount(String x)
        {
            
            int i, wordCount, letterCount;
            letterCount = 0;
            wordCount = 1;
            while (letterCount <= x.Length - 1)
            {
                if (x[letterCount] == ' ' || x[letterCount] == '\n' || x[letterCount] == '\t')
                {
                    wordCount++;
                }

                letterCount++;
            }

            Console.WriteLine("The number of words are {0}", wordCount);
            Console.WriteLine("The number of letters are {0}", letterCount);
        }

        
        static void Main(string[] args)
        {


            string inputString;
            Console.Write("Input the string : ");
            inputString = Console.ReadLine();

            wordsCount(inputString);

            Console.ReadLine();
        }
    }
}