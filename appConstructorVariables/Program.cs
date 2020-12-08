using System;
namespace appConstructorVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student objStudent = new Student("Ty Richardson", "Full Stack Software Engineering", "07/09/1963", 14500);
            Student objStudent2 = new Student("Jack Jones", "Art", "11/23/1981", 25000);
            Console.WriteLine("Student Details");
            objStudent.DisplayDetails();
            Console.WriteLine("Student Details");
            objStudent2.DisplayDetails();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

    class Student
    {
        string studName, programName;
        DateTime dateOfBirth;
       
        decimal fees;

        public Student(string name, string program, string dob, decimal feesPaid)
        {
            studName = name;
            programName = program;
            dateOfBirth = Convert.ToDateTime(dob);
            fees = feesPaid;
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
