using System;

namespace AppStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double temperature,convertedTemp;
            Console.WriteLine("1. Convert from Fahrenheit to Celsius");
            Console.WriteLine("2. Convert from Celsius to Fahrenheit");
            Console.WriteLine("Enter your choice:");
            choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.Write("Enter temperature in Fahren:");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    convertedTemp = TempConverter.FahrenToCelsius(temperature);
                    Console.WriteLine($"Temperature in Cesius{convertedTemp}");
                    break;
                case "2":
                    Console.Write("Enter temperature in Celsius:");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    convertedTemp = TempConverter.CelsiusToFahren(temperature);
                    Console.WriteLine($"Temperature in fahrenheit{convertedTemp}");
                    break;
                default:
                    Console.WriteLine("You have selcted an invalid choice");
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
            double cesiusTemp = (temp - 32) * 5 / 9;
            return cesiusTemp;

        }

    }
    

}
