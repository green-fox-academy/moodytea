using System;

namespace Power
{
    class Program
    {
        static int power(int baseof, int powerRaised)
        {
            if (powerRaised != 0)
                return (baseof * power(baseof, powerRaised - 1));
            else
                return 1;
        }
        static void Main(string[] args)
        {
            int n = 3;
            int n2 = 4;
            Console.WriteLine(power(n, n2));

            Console.ReadLine();
        }
    }
}
