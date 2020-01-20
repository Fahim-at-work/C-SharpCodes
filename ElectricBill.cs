using System;

namespace _2020._01._20
{
    class ElectricBill
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

            total_used = current_meter - last_meter;
            total_energy_charge = total_used * charge_per_unit;
            total_bill = total_energy_charge + monthly_fee;

            Console.WriteLine("Your total bill is {0:c} .", total_bill);
        }
    }
}
