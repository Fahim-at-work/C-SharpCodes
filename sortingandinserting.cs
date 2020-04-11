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
            int temp;
            

            for (int i = 0; i < total_elements; i++)
            {
                Console.Write("Enter the element: ");
                my_array[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("\n");

            Console.Write("The element before sorting are: ");
            for (int i = 0; i < total_elements; i++)
            {
                Console.Write(my_array[i] + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < total_elements; i++)
            {
                for (int j = i + 1; j < total_elements; j++)
                {
                    if (my_array[j] < my_array[i])
                    {
                        temp = my_array[i];
                        my_array[i] = my_array[j];
                        my_array[j] = temp;
                    }
                }
            }


            Console.Write("The element after sorting are: ");
            for (int i = 0; i < total_elements; i++)
            {
                Console.Write(my_array[i] + " ");
            }

            Console.WriteLine("\n");

            Console.Write("Enter the element you want to add to the array: ");
            var new_element = Convert.ToInt32(Console.ReadLine());

            int[] new_array = new int[total_elements + 1];

            for (int i = 0; i <= total_elements; i++)
            {
                if (i == total_elements)
                {
                    new_array[i] = new_element;
                }
                else
                {
                    new_array[i] = my_array[i];
                }
            }

            Console.Write("\n The elements after adding the new element are: ");

            for (int i = 0; i <= total_elements; i++)
            {
                Console.Write(new_array[i] + " ");
            }


        }
    }
}
