using System;

namespace AppVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameofStudent;
            ushort registerNumber;
            char sexCode;
            DateTime dateofBirth;
            byte age;
            string courseCode;
            int mark;
            float classAverage;
            decimal feesPaid;
            bool coursePassed;

            nameofStudent = "Mark Peters"; // double quotes for string type
            registerNumber  = 678;
            sexCode = 'M'; // single quotes for char type
            dateofBirth = Convert.ToDateTime("11/22/1995");
            age = 25;
            courseCode = "PRG101";
            mark = 87;
            classAverage = 84.57f;
            feesPaid = 1250.75m;
            coursePassed = true;
            
            Console.WriteLine("Student Details:");
            Console.WriteLine("Student Name: " + nameofStudent);
            Console.WriteLine("Register Number: " + registerNumber);
            Console.WriteLine("Gender: " + sexCode);
            Console.WriteLine("DOB: " + dateofBirth);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course Code: " + courseCode);
            Console.ReadLine();
            Console.WriteLine("Score: " + mark);
            Console.WriteLine("Class Average: " + classAverage);
            Console.WriteLine("Fees Paid: $" + feesPaid);
            Console.WriteLine("Pass/Fail: " + coursePassed);
        }
    }
}
