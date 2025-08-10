namespace RayanStudentCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Student student = new Student("Rayan Zulfiqar", 2238, "BSCS", "G-2");
            
            student.Name = "   ";
            student.Display();

            Student student1 = new Student("", 2241, "BSCS", "G-1");
            //student1.Display();


        }
    }
}
