using System;

namespace Bunnies1
{
    class Program
    {
        static int multiplic(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else
                return x + multiplic(x, y - 1);
        }
    

    static void Main(string[] args)
        {
            int n = 13;
            int n2 = 2;
            Console.WriteLine(multiplic(n, n2));
            Console.ReadKey();
        }
    }
}
