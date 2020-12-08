using System;
using System.Collections;
namespace hashtableCapitals
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, country,capital;
            Hashtable htblCountries = new Hashtable();
         
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("****");
                Console.WriteLine("1. Add Country");
                Console.WriteLine("2. Find Capital");
                Console.WriteLine("3. List Countries");
                Console.Write("Choose Your Option(1/2/3):");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            Console.Write("Enter country name:");
                            country = Console.ReadLine();
                            Console.Write("Enter capital:");
                            capital = Console.ReadLine();
                            htblCountries.Add(country,capital);

                            Console.Write("Do you want to continue adding country(Y/N)?:");
                            var answer = Console.ReadLine();
                            while (string.IsNullOrEmpty(answer.ToString()) || ((answer.ToUpper().Equals("Y")) == false && (answer.ToUpper().Equals("N")) == false))
                            {
                                Console.Write("Invalid choice...Do you want to continue adding country(Y/N)?:");
                                answer = Console.ReadLine();
                            }

                            if (answer.ToUpper().Equals("N") == true)
                                break;
                        }
                        break;
                    case "2":
                        Console.Write("Enter country name for which you want the capital:");
                        country = Console.ReadLine();

                        if (htblCountries.ContainsKey(country))
                            Console.WriteLine($"Country: {country}  Capital: {htblCountries[country]} ");
                        else
                            Console.WriteLine($"Country {country} is not found in the list");
                        break;
                    case "3":
                        if (htblCountries.Count == 0)
                            Console.WriteLine("Country List is Empty");
                        else
                        {
                            Console.WriteLine("*********Countries & Capitals********");
                            foreach (DictionaryEntry item in htblCountries) //Traverses through the Hashtable
                            {
                                Console.WriteLine("Country:  {0}   Capital:  {1}", item.Key, item.Value);
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.Write("Do you want to continue(Y/N)?:");
                var response = Console.ReadLine();
                while (string.IsNullOrEmpty(response.ToString()) || ((response.ToUpper().Equals("Y")) == false && (response.ToUpper().Equals("N")) == false))
                {
                    Console.Write("Invalid choice...Do you want to continue(Y/N)?:");
                    response = Console.ReadLine();
                }

                if (response.ToUpper().Equals("N") == true)
                    break;

                Console.Clear();
            }
        }
    }
}