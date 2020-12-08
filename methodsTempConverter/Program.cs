using System;

namespace methodsTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsiusTempCanada, fahrenCanada, celsiusTempUSA, fahrenUSA;
            Console.Write("Enter the celsius temp of Canada:");
            celsiusTempCanada = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the celsius temp of USA:");
            celsiusTempUSA = Convert.ToDouble(Console.ReadLine());

            fahrenCanada = ConvertTemp(celsiusTempCanada);
            fahrenUSA= ConvertTemp(celsiusTempUSA);

            Console.WriteLine($"Canada Temp in Fahrenheit {fahrenCanada}");
            Console.WriteLine($"USA Temp in Fahrenheit { fahrenUSA}");
            Console.ReadKey();

        }

            static double ConvertTemp(double temp)
            {
                double fahrenTemp = (temp * 9 / 5) + 32;
                return fahrenTemp;

            }
        }
    }
}
