using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are there in the class? ");
            var number_of_students = Convert.ToInt32(Console.ReadLine());


            var student_name = new string[number_of_students];
            var student_marks = new int[number_of_students];

            for (int i = 0; i < number_of_students; i++)
            {
                Console.Write("Enter the student's name: ");
                student_name[i] = Console.ReadLine();

                Console.Write("Enter the student's grade: ");
                student_marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < number_of_students; i++)
            {
                Console.WriteLine("Student Name: {0}", student_name[i]);
                Console.WriteLine("Student Marks: {0}", student_marks[i]);
            }

            Console.ReadLine();

        }
    }
}
