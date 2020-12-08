using System;

namespace staticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double temperature, convertedTemp;
            Console.WriteLine("Enter 1 to convert from Fahrenheit to Celsius");
            Console.WriteLine("Enter 2 to convert from Celsius to Fahrenheit");
            Console.WriteLine("Enter your choice:");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.Write("Enter temperature in Fahrenheit: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    convertedTemp = TempConverter.FahrenToCelsius(temperature);
                    Console.WriteLine($"Temperature in Celsius: {convertedTemp:F2}");
                    break;
                case "2":
                    Console.Write("Enter temperature in Celsius: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    convertedTemp = TempConverter.CelsiusToFahren(temperature);
                    Console.WriteLine($"Temperature in Fahrenheit: {convertedTemp:F2}");
                    break;
                default:
                    Console.WriteLine("You have selected an invalid choice");
                    break;

            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }

    public static class TempConverter
    {
        public static double CelsiusToFahren(double temp)
        {
            double fahrenTemp = (temp * 9 / 5) + 32;
            return fahrenTemp;

        }

        public static double FahrenToCelsius(double temp)
        {
            double celsiusTemp = (temp - 32) * 5 / 9;
            return celsiusTemp;

        }

    }
}
