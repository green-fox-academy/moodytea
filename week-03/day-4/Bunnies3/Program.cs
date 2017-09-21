using System;

namespace Bunnies3
{
    class Program
    {
        static int EarCounter (int num)
        {
            if (num >1)
            {
                return (num % 2 + 2 + EarCounter(num-1));
            }
            else if (num==1)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int HowManyBunnies = 8;
            Console.WriteLine(EarCounter(HowManyBunnies));
            Console.ReadKey();
        }
    }
}
