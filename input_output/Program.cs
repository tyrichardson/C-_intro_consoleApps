/*
** Application for demonstating basic input / output in C#
** Author: Ty Richardson
** November 20, 2020
*/

using System;

namespace input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
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

            // Initializations
            mark = 87;
            classAverage = 84.57f;
            feesPaid = 1250.75m;
            coursePassed = true;
            
            // Input_Output for user initialization of variables
            Console.WriteLine("Student Details");
            Console.WriteLine("Enter your name.");
            nameofStudent = Console.ReadLine();
            Console.WriteLine("Enter your registration number.");
            registerNumber = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter M or F for your gender.");
            sexCode = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your Date of Birth (DOB) as mm/dd/yyyy.");
            dateofBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your age.");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter your Course Code.");
            courseCode = Console.ReadLine();
            Console.WriteLine("Press any key for your results...");
            Console.ReadLine();

            // Output of student report
            Console.WriteLine("Student {0} has Register Number {1}", nameofStudent, registerNumber);
            Console.WriteLine("Gender: " + sexCode);
            Console.WriteLine("DOB: {0}", dateofBirth.ToString("MM/dd/yyyy"));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Your score is {0}. The class average is {1}", mark, classAverage);
            Console.WriteLine("Fees Paid: {0:C2}", feesPaid);
            Console.WriteLine("Pass/Fail: " + coursePassed);
        }
    }
}
