using System;
namespace AppConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            objStudent.DisplayDetails();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

    class Student
    {
        string studName, programName;
        DateTime dateOfBirth;
       
        decimal fees;

        public Student()
        {
            studName = "Alex Peter";
            programName = "Software Development";
            dateOfBirth = Convert.ToDateTime("10/11/2001");
            fees = 6000;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name of Student: {studName}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            Console.WriteLine($"Program Name: {programName}");
            Console.WriteLine($"Fees: {fees}");
        }
    }
}
