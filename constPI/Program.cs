using System;

namespace constPI
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double area, radius;
            radius = 4.5;
            area = PI * radius * radius;
            Console.WriteLine("The Area of my circle is {0} when the Radius is {1}.", area, radius);
        }
    }
}
