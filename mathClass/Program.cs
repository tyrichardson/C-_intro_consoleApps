using System;

namespace mathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.Write("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * Math.Pow(radius, 2);
            area = Math.Round(area, 2);
            Console.WriteLine($"The area of the circle is: {area}");
        }
    }
}
