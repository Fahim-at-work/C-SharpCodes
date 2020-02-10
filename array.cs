using System;

namespace _2020._02._10
{
    class Program
    {
        static void Main(string[] args)
        {
            

		   
		    int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original: ");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }

            Array.Reverse(num);
            Console.WriteLine("\n\nReversed: ");
            foreach (int j in num)
            {
                Console.Write(j + " ");
            }

            
        }
    }
}
