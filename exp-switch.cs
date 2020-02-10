using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many years of experience you have? ");
            var exp = Convert.ToInt32(Console.ReadLine());

            switch (exp)
            {
                case 0:
                    Console.WriteLine("You are an inexperienced developer");
                    break;
                case 1:
                    Console.WriteLine("You are a Junior developer");
                    break;
                case 2:
                    Console.WriteLine("You are an intermediate developer");
                    break;
                case 3:
                    Console.WriteLine("You are advanced developer");
                    break;
                default:
                    Console.WriteLine("You are a senior developer");
                    break;
            }

	    Console.ReadLine();

        }
    }
}
