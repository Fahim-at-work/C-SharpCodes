using System;
using System.Collections.Generic;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var student_name = new List<string>();
            var student_marks = new List<int>();

            var flag = true;

            while(flag)
            {
                Console.Write("Enter the student's name: ");
                student_name.Add(Console.ReadLine());

                Console.Write("Enter the student's marks: ");
                student_marks.Add(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Want to add another student? y / n: ");
                var choice = Console.ReadLine();
                choice = choice.ToLower();

                if (choice != "y")
                {
                    flag = false;
                }
            }

            for (int i = 0; i < student_name.Count; i++)
            {
                Console.WriteLine("\nStudent Name: {0}", student_name[i]);
                Console.WriteLine("Student Marks: {0}", student_marks[i]);
            }

            Console.ReadLine();

        }
    }
}
