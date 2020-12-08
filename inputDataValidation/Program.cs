using System;

namespace inputDataValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            decimal salary;
            try
            {
                Console.Write("Enter employee name:");
                name = Console.ReadLine();
                if(string.IsNullOrEmpty(name))
                {
                    Console.Write("Name cannot be empty");
                    Console.ReadKey();
                    return;
                }
                Console.Write("Enter age");
                var ageValue = Console.ReadLine();
                bool parseAgeSuccess = int.TryParse(ageValue, out age);
                if(parseAgeSuccess==false || !(age>=18 && age<=65) )
                {
                    Console.Write("Age should be a numerical age between 18 to 65"); 
                    Console.ReadKey();
                    return;
                }

                Console.Write("Enter salary");
                var salaryValue = Console.ReadLine();
                bool parseSalarySuccess = decimal.TryParse(salaryValue, out salary);
                if (parseSalarySuccess == false )
                {
                    Console.Write("Salary should be a numerical value"); 
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Age: {0}", age);
                Console.WriteLine("Salary: {0}", salary);
                Console.ReadKey();


            }
            catch (Exception e1)
            {
                Console.WriteLine("Some exception occurred: {0}", e1.Message);
            }
        }
    }
}
