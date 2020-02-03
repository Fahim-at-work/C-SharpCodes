using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter degree celsius to calculate kelvin and fahrenheit: ");
            var celsius = Convert.ToDecimal(Console.ReadLine());

            decimal kelvin, fahrenheit;

            kelvin = celsius + 273.15M;
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Kelvin: {0}", kelvin);
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);


            Console.ReadLine();

        }
    }
}
