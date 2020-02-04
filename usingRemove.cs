using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(removingChar("FahimShariff", 1));
            Console.WriteLine(removingChar("FahimShariff", 4));
            Console.WriteLine(removingChar("FahimShariff", 6));

        }

        public static string removingChar(string s, int i)
        {
            return s.Remove(i, 3);
        }
    }
}
