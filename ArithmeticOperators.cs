using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking input from the user
            Console.Write("Enter first number: ");
            var num_one = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Select an operator +, -, *, /, % : ");
            var operator_entered = Console.ReadLine();

            Console.Write("Enter second number: ");
            var num_two = Convert.ToDecimal(Console.ReadLine());

            //Checking the cases and printing the output
            
            switch (operator_entered)
            {
                case "+":
                    Console.WriteLine(num_one + num_two);
                    break;

                case "-":
                    Console.WriteLine(num_one - num_two);
                    break;

                case "*":
                    Console.WriteLine(num_one * num_two);
                    break;

                case "/":
                    Console.WriteLine(num_one / num_two);
                    break;

                case "%":
                    Console.WriteLine(num_one % num_two);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadLine();

        }
    }
}
