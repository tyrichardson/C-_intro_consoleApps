using System;
using System.Text;

namespace AppRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PwdLength = 8;
            StringBuilder sbPassword = new StringBuilder();
            sbPassword.Append("");
            Random rand = new Random();
            for (int k = 1; k <= PwdLength; ++k)

            {
                int x = rand.Next(1, 100);
                int r = x % 2;
                if (r == 0)
                {
                    sbPassword.Append((char)rand.Next(97, 122));
                }
                else
                {
                    sbPassword.Append((char)rand.Next(65, 90));
                }
            }
            Console.WriteLine($"Password Generated: {sbPassword}");
            Console.ReadKey();
        }
    }
}
