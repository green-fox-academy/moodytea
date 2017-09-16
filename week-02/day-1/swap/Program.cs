using System;

namespace ex08
{
    class Program
    {
        public static void Main(string[] args)
        {
			int a;
			int b;

			a =  123;
            b = 526;

            a += b;
            b = a-b;
            a -= b;


            Console.WriteLine(a + " " + b);
        }
    }
}
