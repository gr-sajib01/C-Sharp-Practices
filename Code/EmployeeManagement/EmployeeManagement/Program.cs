using System;

namespace EmployeeManagement
{
    class Employee
    {
        public string Name;
        public int Age;

        public virtual void ShowDetails()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Age: " + Age);
        }
    }

    class Manager : Employee
    {
        public string Department;

        public override void ShowDetails()
        {
            Console.WriteLine("Manager Name: " + Name);
            Console.WriteLine("Manager Age: " + Age);
            Console.WriteLine("Department: " + Department);
        }
    }

    class Developer : Employee
    {
        public string Language;

        public override void ShowDetails()
        {
            Console.WriteLine("Developer Name: " + Name);
            Console.WriteLine("Developer Age: " + Age);
            Console.WriteLine("Programming Language: " + Language);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Sajib";
            emp1.Age = 22;

            Manager manager1 = new Manager();
            manager1.Name = "Anubhab sir";
            manager1.Age = 40;
            manager1.Department = "HR";

            Developer dev1 = new Developer();
            dev1.Name = "Rahim";
            dev1.Age = 30;
            dev1.Language = "C#";

            emp1.ShowDetails();
            Console.WriteLine();

            manager1.ShowDetails();
            Console.WriteLine();

            dev1.ShowDetails();
        }
    }
}