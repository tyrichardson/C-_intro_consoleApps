using System;
using System.Collections;
namespace AppArListCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, country;
            ArrayList arCountries = new ArrayList();
            while (true)
            {
                Console.Write("Enter country name:");
                country = Console.ReadLine();
                arCountries.Add(country);
                Console.Write("Do you want to add another country (Y/N)?");
                var answer = Console.ReadLine();
                while (string.IsNullOrEmpty(answer.ToString()) || ((answer.ToUpper().Equals("Y")) == false && (answer.ToUpper().Equals("N")) == false))
                {
                    Console.Write("Invalid choice...Do you want to add another country(Y/N)?");
                    answer = Console.ReadLine();
                }
                if (answer.ToUpper().Equals("N") == true)
                    break;

            }
            Console.WriteLine("Menu");
            Console.WriteLine("****");
            Console.WriteLine("1. Search Country");
            Console.WriteLine("2. List Countries");
            Console.WriteLine("3. Remove Country");
            Console.WriteLine("4. Remove All Countries");
            Console.Write("Choose your option(1/2/3/4)");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter country name to search for:");
                    country = Console.ReadLine();
                    if (arCountries.Contains(country))
                    {
                        Console.WriteLine($"Country {country} is found at the location {arCountries.IndexOf(country) + 1}");

                    }
                    else
                    {
                        Console.WriteLine($"Country {country} is not found in the array lis");
                    }
                    break;
                case "2":
                    if (arCountries.Count == 0)
                        Console.WriteLine("Country list is empty");
                    else
                        foreach (var item in arCountries)
                        {
                            Console.WriteLine(item);
                        }
                    break;
                case "3":
                    Console.Write("Enter country name to be deleted from the list");
                    country = Console.ReadLine();
                    if (arCountries.Contains(country))
                    {
                        arCountries.Remove(country);
                        Console.WriteLine($"Country {country} has been removed from the list");
                        foreach (var item in arCountries)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                        Console.WriteLine($"Country {country} is not found in the array list");
                    break;
                case "4":
                    if (arCountries.Count == 0)
                        Console.WriteLine("Country list is empty");
                    else
                    {
                        arCountries.Clear();
                        foreach (var item in arCountries)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
