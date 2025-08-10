using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanStudentCRUD
{
    class Student
    {
        string name;
        int rollno;
        string major;
        string section;

        public Student()
        {
            
        }

        public Student(string name, int rollno, string major, string section)
        {
            this.name = name;
            this.rollno = rollno;
            this.major = major;
            this.section = section;
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
            }
        }

        public int RollNo
        {
            get { return rollno; }
            set
            {
                if (value > 0)
                {
                    rollno = value;
                }
            }
        }

        public string Major
        {
            get { return major; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    major = value;
                }
            }
        }

        public string Section
        {
            get { return section; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    section = value;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Major: " + major);
            Console.WriteLine("Section: " + section);
        }
    }
}
