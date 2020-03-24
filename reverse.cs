using System;

namespace Assignment
{
    class Program
    {  
        static void Main(string[] args)
        {


            String outputString = "";
            Console.WriteLine("Enter a string to find the reverse");
            var inputString = Console.ReadLine();

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                outputString += inputString[i];
            }

            Console.WriteLine($"The reverse of the string is {outputString}");
            Console.ReadLine();
        }
    }
}


