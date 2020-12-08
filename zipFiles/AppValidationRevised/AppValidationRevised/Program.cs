using System;
namespace AppValidationRevised
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            decimal salary;

            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Name can't be empty! Enter your name again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter Age:");
            var ageString = Console.ReadLine();
            while (!int.TryParse(ageString, out age) || (int.TryParse(ageString, out age) && !(age >= 18 && age <= 65)))
            {
                Console.Write("Age should be a numerical value in the range 18 to 65, Enter your age   again: ");
                ageString = Console.ReadLine();
            }

            Console.Write("Enter the salary: ");
            var salaryString = Console.ReadLine();
            while (!decimal.TryParse(salaryString, out salary))
            {
                Console.Write("Salary should be a numerical value, Enter your salary again: ");
                salaryString = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Awesome You have entered a name and Your name is: {0}", name);
            Console.WriteLine("Perfect You have entered a number and Your age is: {0}", age);
            Console.WriteLine("Wonderful You have entered a salary and Your salary is: {0}", salary);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
