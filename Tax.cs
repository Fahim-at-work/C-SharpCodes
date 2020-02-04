using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //taking input from the user
            Console.Write("Enter the total hours worked: ");
            var hours_worked = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the hourly pay rate: ");
            var hourly_pay = Convert.ToDecimal(Console.ReadLine());

            //declaring the variables
            decimal tax_rate = 18 / 100M, gross_pay, tax_amount, take_home_pay;

            //calculating the gross pay, tax amount, take home 

            gross_pay = hourly_pay * hours_worked;

            tax_amount = gross_pay * tax_rate;

            take_home_pay = gross_pay - tax_amount;

            //Printing the output with dollar sign and specific decimal places
            Console.WriteLine("\nGross Pay: {0:C}", gross_pay);
            Console.WriteLine("Tax  Rate: {0:0}%", tax_rate * 100);
            Console.WriteLine("Tax Amount: {0:C}", tax_amount);
            Console.WriteLine("Take Home Pay: {0:C}", take_home_pay);

            Console.ReadLine();

        }
    }
}
