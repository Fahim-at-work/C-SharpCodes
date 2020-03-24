using System;

namespace Assignment
{
    class Program
    {  
        static void Main(string[] args)
        {

            int alphabetCount = 0, digitCount = 0, specialCount = 0;
            String inputString;

            Console.WriteLine("Enter a string with special characters");
            inputString = Console.ReadLine();

            for(int i = 0; i < inputString.Length; i++)
            {
                if ((inputString[i] >= 'a' && inputString[i] <= 'z') || (inputString[i] >= 'A' && inputString[i] <= 'Z'))
                {
                    alphabetCount++;
                }
                else if(inputString[i] >= '0' && inputString[i] <= '9')
                {
                    digitCount++;
                }
                else
                {
                    specialCount++;
                }
            }

            Console.WriteLine("The number of alphabets are {0}", alphabetCount);
            Console.WriteLine("The number of digits are {0}", digitCount);
            Console.WriteLine("The number of special characters are {0}", specialCount);

        }
    }
}


