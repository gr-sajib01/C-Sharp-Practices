using System;

namespace StudentRecord
{
    class Student
    {
        public string Name;
        public int ID;

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student ID: " + ID);
        }
    }

    class Undergraduate : Student
    {
        public string Semester;

        public override void DisplayInfo()
        {
            Console.WriteLine("Undergraduate Student");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Semester: " + Semester);
        }
    }

    class Postgraduate : Student
    {
        public string ResearchTopic;

        public override void DisplayInfo()
        {
            Console.WriteLine("Postgraduate Student");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Research Topic: " + ResearchTopic);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Rahim";
            student1.ID = 60392;

            Undergraduate ugStudent1 = new Undergraduate();
            ugStudent1.Name = "Sajib";
            ugStudent1.ID = 60374;
            ugStudent1.Semester = "6th";

            Postgraduate pgStudent1 = new Postgraduate();
            pgStudent1.Name = "Karim";
            pgStudent1.ID = 354435;
            pgStudent1.ResearchTopic = "Artificial Intelligence";

            student1.DisplayInfo();
            Console.WriteLine();

            ugStudent1.DisplayInfo();
            Console.WriteLine();

            pgStudent1.DisplayInfo();
        }
    }
}