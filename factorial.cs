using System;

namespace _2020._02._10
{
    class Program
    {
        static void Main(string[] args)
        {
            

		   
		    Console.Write("Enter a number you want to calculate the factorial of: ");
            var num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("The factorial of {0} is {1}", num, fact);


            
        }
    }
}
