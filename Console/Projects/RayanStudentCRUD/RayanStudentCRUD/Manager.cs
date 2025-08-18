using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RayanStudentCRUD
{
    class Manager
    {
        List<Student> students;

        public Manager()
        {
            students = new List<Student>();
        }

        void Hold()
        {
            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey(true);
        }

        public void Create()
        {
            Console.Clear();

            Student student = new Student();

            Console.WriteLine("\nEnter Student's Name:");
            student.Name = GetStringInput();
            Console.WriteLine("\nEnter Student's Roll No:");
            student.RollNo = GetIntInput();
            Console.WriteLine("\nEnter Student's Major:");
            student.Major = GetStringInput();
            Console.WriteLine("\nEnter Student's Section:");
            student.Section = GetStringInput();

            students.Add(student);
            Console.WriteLine("Student Added Successfully!");

            Hold();
        }

        int GetIntInput()
        {
            int number = 0;

            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number <= 0)
                        Console.WriteLine("The data must be correct!");
                }
                catch 
                {
                    Console.WriteLine("Incorrect input!");
                }
            }while (number <= 0);

            return number;
        }

        string GetStringInput()
        {
            string? str;

            do
            {
                str = Console.ReadLine();

                if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                    Console.WriteLine("You must enter correct data!");
            }
            while (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str));

            return str;
        }

        public void Retrieve()
        {
            Console.Clear();

            Console.WriteLine("Enter the Student's Roll No to view details:");
            int rollNo = GetIntInput();

            foreach (Student student in students)
            {
                if (student.RollNo == rollNo)
                {
                    student.Display();

                    Hold();
                    return;
                }
            }

            Console.WriteLine("Student Not Found!");
            Hold();
        }

        public void RetrieveAll()
        {
            Console.Clear();

            if (students.Count == 0)
            {
                Console.WriteLine("No Students found!");
                Hold();
                return;
            }

            foreach (Student std in students)
            {
                std.Display();
            }

            Hold();
        }

        public void Update()
        {
            Console.Clear();

            Console.WriteLine("Enter the Student's Roll No to update:");
            int rollNo = GetIntInput();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].RollNo == rollNo)
                {
                    Console.WriteLine("\nEnter Student's Name:");
                    students[i].Name = GetStringInput();
                    Console.WriteLine("\nEnter Student's Major:");
                    students[i].Major = GetStringInput();
                    Console.WriteLine("\nEnter Student's Section:");
                    students[i].Section = GetStringInput();

                    Console.WriteLine($"Student of roll no {rollNo} updated successfully!");

                    Hold();
                    return;
                }
            }
            Console.WriteLine($"Student not found of roll no {rollNo}.");

            Hold();
        }

        public void Delete()
        {
            Console.Clear();

            Console.WriteLine("Enter the Student's Roll No to delete:");
            int rollNo = GetIntInput();

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].RollNo == rollNo)
                {
                    students.RemoveAt(i);

                    Console.WriteLine($"Student of roll no {rollNo} deleted successfully!");

                    Hold();
                    return;
                }
            }
            Console.WriteLine($"Student not found of roll no {rollNo}.");

            Hold();
        }
    }
}
