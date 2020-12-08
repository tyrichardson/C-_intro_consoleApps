using System;

namespace staticMethodSalaryCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int empCode;
            double empSalary, taxDue = 0, netSalary = 0;
            EmpSalaries[] objEmpSal = new EmpSalaries[3];
            Console.WriteLine("You will enter employee code and salary.");
            for ( int i = 0; i < objEmpSal.Length; i++ )
            {
                Console.WriteLine("Enter employee code: ");
                empCode = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the employee's salary: ");
                empSalary = Convert.ToDouble(Console.ReadLine());
                objEmpSal[i] = new EmpSalaries(empCode, empSalary, taxDue, netSalary);
                objEmpSal[i].computeTax();
            }
            Console.WriteLine("Press any key to run employee salary report.");
            Console.ReadLine();
            for ( int i = 0; i < objEmpSal.Length; i++ ) 
            {
                objEmpSal[i].printReport();

            }

        }
    }

    class EmpSalaries
    {
        int code;
        double salary, taxes, net;
        public EmpSalaries(int empCode, double empSalary, double taxDue, double netSalary)
        {
            code = empCode;
            salary = empSalary;
            taxes = taxDue;
            net = netSalary;
        }
        public void computeTax()
        {
            int rate;
            if (salary < 50000)
            {
                rate = 15;
                taxes = salary * rate/100;
                net = salary - taxes;
            } else {
                rate = 25;
                taxes = salary * rate/100;
                net = salary - taxes;
            }
            
        }
        public void printReport()
        {
            Console.WriteLine($"Employee Code {code} owes {taxes:C2} in taxes, so takes home {net:C2}");
        }
    }
}
