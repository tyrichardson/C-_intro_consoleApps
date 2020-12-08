using System;

namespace array2D
{
    class Program
    {
        static void Main(string[] args)
        {
        int[,] population = new int[5, 2];
            //Reading the population for 5 years
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {
                    if (j == 0)
                    {
                        Console.Write("Enter the year:");
                        population[i, j] = Convert.ToInt16(Console.ReadLine());
                    }
                    if (j == 1)
                    {
                        Console.Write("Enter the population");
                        population[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            //Displays the population for years
            Console.WriteLine("Population for five years");
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 2; ++j)
                {

                    Console.Write("{0}\t", population[i, j]);


                }
                Console.WriteLine();
            }
           // Console.ReadKey(); needed on Windows not Mac

int[,] arr = {{1, 2, 3}, {4, 5, 6}};
           Console.WriteLine("arr.Length is {0}", arr.Length);
           for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    Console.Write("{0}\t", arr[i, j]);
                }

        }
        }
    }

}


