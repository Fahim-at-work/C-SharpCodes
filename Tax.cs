using System;

namespace _2020._01._20
{
    class Tax
    {
        static void Main(string[] args)
        {
            double tax = 0.13;
            double total_cost, total_tax, final_price;
            double price_of_item;

            
            Console.Write("Enter the price of the item: ");
            price_of_item = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of items you want: ");
            var item_number = Convert.ToInt32(Console.ReadLine());

            total_cost = item_number * price_of_item;
            total_tax = total_cost * tax;
            final_price = total_cost + total_tax;

            Console.WriteLine("The total cost is {0}", final_price);

            Console.ReadLine();
        }
    }
}
