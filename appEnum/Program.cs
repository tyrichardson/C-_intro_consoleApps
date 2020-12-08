using System;

namespace appEnum
{
enum AirDistance
    {
        Toronto=3550,
        NewYork=3424,
        Delhi=4171,
        Dubai=3403,
        Muscat=3617,
        Amsterdam=221,
        Paris=213
    }
    class Program
    {
        static void Main(string[] args)
        {
            string destCity;
            int distance;
            decimal fuelConsumption;
            while(true)
            {
                Console.Write("Enter destination city: ");
                destCity = Console.ReadLine().ToUpper();
                switch(destCity)
                {
                    case "TORONTO":
                        fuelConsumption = (int)AirDistance.Toronto * 20;
                        distance = (int)AirDistance.Toronto;
                        break;

                    case "NEWYORK":
                        fuelConsumption = (int)AirDistance.NewYork * 20;
                        distance = (int)AirDistance.NewYork;
                        break;

                    case "DELHI":
                        fuelConsumption = (int)AirDistance.Delhi * 20;
                        distance = (int)AirDistance.Delhi;
                        break;

                    case "DUBAI":
                        fuelConsumption = (int)AirDistance.Dubai * 20;
                        distance = (int)AirDistance.Dubai;
                        break;

                    case "MUSCAT":
                        fuelConsumption = (int)AirDistance.Muscat * 20;
                        distance = (int)AirDistance.Muscat;
                        break;

                    case "AMSTERDAM":
                        fuelConsumption = (int)AirDistance.Amsterdam * 20;
                        distance = (int)AirDistance.Amsterdam;
                        break;

                    case "PARIS":
                        fuelConsumption = (int)AirDistance.Paris * 20;
                        distance = (int)AirDistance.Paris;
                        break;

                    default:
                        fuelConsumption = 0;
                        destCity = "Invalid City Entered";
                        distance = 0;
                        break;
                }

                Console.WriteLine($"Source City: London   Destination City: {destCity}");
                Console.WriteLine($"Air distance in miles: {distance}   Fuel Consumption in Litres: {fuelConsumption}");

                Console.Write("Do you want to continue(Y/N)");
                var answer = Console.ReadLine();

                while(string.IsNullOrEmpty(answer.ToString()) || ((answer.ToUpper().Equals("Y")) == false && (answer.ToUpper().Equals("N")) == false))
                {
                    Console.Write("Invalid choice...Do you want to continue with another city (Y/N)?");
                    answer = Console.ReadLine();

                }
                
                if(answer.ToUpper().Equals("N")==true)
                {
                    break;
                }

                Console.Clear();

            }
       }
    }   
}
