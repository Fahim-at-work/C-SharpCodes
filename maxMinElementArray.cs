using System;

namespace finalassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements you want to add in array: ");
            var total_elements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            int[] my_array = new int[total_elements];
            int max_number, min_number;
            

            for (int i = 0; i < total_elements; i++)
            {
                Console.Write("Enter the element: ");
                my_array[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("\n");

            Console.Write("The element are: ");
            for (int i = 0; i < total_elements; i++)
            {
                Console.Write(my_array[i] + " ");
            }

            Console.WriteLine("\n");
            max_number = my_array[0];
            min_number = my_array[0];

            for (int i = 0; i < total_elements; i++)
            {
                if(max_number < my_array[i])
                {
                    max_number = my_array[i];
                }

                if (min_number > my_array[i])
                {
                    min_number = my_array[i];
                }
            }

            Console.WriteLine("The maximum element is: {0}", max_number);
            Console.WriteLine("The minimum element is: {0}", min_number);

        }
    }
}
