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

        public void Create()
        {
            Student student = new Student();

            Console.WriteLine("Enter Candidate's Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Candidate's Roll No:");
            student.RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Candidate's Major:");
            student.Major = Console.ReadLine();
            Console.WriteLine("Enter Candidate's Section:");
            student.Section = Console.ReadLine();
            Console.WriteLine("Candidate Created Successfully!");
        }

        public void Read()
        {
            Console.WriteLine("Enter the Candidate's Roll No to view details:");
            int rollNo = Convert.ToInt32(Console.ReadLine());

            foreach (Student student in students)
            {
                if (student.RollNo == rollNo)
                {
                    student.Display();
                    return;
                }
            }

            Console.WriteLine("Student Not Found!");
        }

        public void Update()
        {
            
        }

        
    }
}
