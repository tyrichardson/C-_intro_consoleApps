using System;
namespace AppDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountNumber;
            DateTime depositDate, withdrawalDate;
            TimeSpan interval;
            int depositDays;
            double depositAmount, interestRate, interestAmount, amountPayable;
            try
            {
                Console.Write("Enter the account number:");
                accountNumber = Console.ReadLine();
                Console.Write("Enter the deposit Amount:");
                depositAmount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the deposit date:(mm/dd/yyyy)");
                depositDate = Convert.ToDateTime(Console.ReadLine());
                while (true)
                {
                    Console.Write("Enter the withdrawl date (mm/dd/yyyy)");
                    withdrawalDate = Convert.ToDateTime(Console.ReadLine());
                    if (withdrawalDate < depositDate || withdrawalDate > DateTime.Today)
                    {
                        Console.WriteLine("Withdrawl date should be greater than deposit date and should not be larger than today");

                    }
                    else
                    {
                        break;
                    }

                }
                interval = withdrawalDate - depositDate;
                depositDays = (int)interval.TotalDays;
                if (depositDays <= 90)
                {
                    interestRate = 5;

                }
                else if (depositDays <= 180)
                {
                    interestRate = 7.5;
                }
                else
                {
                    interestRate = 9;
                }
                interestAmount = depositAmount * interestRate / 100;
                amountPayable = depositAmount + interestAmount;
                Console.WriteLine();
                String data = String.Format("{0,-31}{1,-17}{2,-32}\n"," ","Account Statement"," ");
                data += String.Format("{0,-31}{1,-17}{2,-32}\n", " ", "*****************", " ");
                data += String.Format("{0,-20}{1,-20}{2,-20}{3,-20}\n", "Account Number", accountNumber, "Deposit Amount", depositAmount);
                data += String.Format("{0,-20}{1,-20}{2,-20}{3,-20}\n", "Deposit Date", depositDate.ToString("dd-MMM-yyyy"), "Withdrawal Date", withdrawalDate.ToString("dd-MMM-yyyy"));
                data += String.Format("{0,-20}{1,-20}{2,-20}{3,-20}\n", "Deposit Days", depositDays, "Interest Rate", interestRate);
                data += String.Format("{0,-20}{1,-20}{2,-20}{3,-20}\n", "Interest Amount", interestAmount, "Amount Payable", amountPayable);
                Console.WriteLine(data);


            }
            catch(FormatException ex1)
            {
                Console.WriteLine(ex1.Message+"Please check the format of the data  entered");

            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}
