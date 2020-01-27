using System;

namespace _2020._01._27
{
    class Program
    {
        static void Main(string[] args)
        {
            const int last_meter = 39803;
            const decimal monthly_fee = 10.00M;
            int total_used;
            decimal charge_per_unit = 0.095M;
            decimal total_bill, total_energy_charge;

            Console.Write("Enter your current meter reading: ");
            var current_meter = Convert.ToInt32(Console.ReadLine());

            if (current_meter > 50000)
            {
                Console.WriteLine("You have to pay $100 more as extra charges.");
                var pay_more = 100;
                total_used = current_meter - last_meter;
                total_energy_charge = total_used * charge_per_unit;
                total_bill = total_energy_charge + monthly_fee + pay_more;
                Console.WriteLine("Your total bill is {0:c} including your extra charges that is {1:c} .", total_bill, pay_more);

            }
            else
            {
                Console.WriteLine("You're good. ");
                total_used = current_meter - last_meter;
                total_energy_charge = total_used * charge_per_unit;
                total_bill = total_energy_charge + monthly_fee;
                Console.WriteLine("Your total bill is {0:c} .", total_bill);
            }

            
        }
    }
}
