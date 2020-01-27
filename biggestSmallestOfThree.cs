using System;

namespace _2020._01._27
{
    class Program
    {
        static void Main(string[] args)
        {
            

		    Console.WriteLine("Enter three numbers to find the biggest and the smallest number");
            Console.Write("Enter first number: ");
            var num_one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            var num_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            var num_three = Convert.ToInt32(Console.ReadLine());

            if (num_one > num_two && num_one > num_three)
            {
                Console.WriteLine("The biggest number is {0}", num_one);
            }
            else if (num_two > num_one && num_two > num_three)
            {
                Console.WriteLine("The biggest number is {0}", num_two);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}", num_three);
            }


            if (num_one < num_two && num_one < num_three)
            {
                Console.WriteLine("The smallest number is {0}", num_one);
            }
            else if (num_two < num_one && num_two < num_three)
            {
                Console.WriteLine("The smallest number is {0}", num_two);
            }
            else
            {
                Console.WriteLine("The smallest number is {0}", num_three);
            }

            
        }
    }
}
