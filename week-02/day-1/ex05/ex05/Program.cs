using System;

namespace ex05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 22;
            int b = 13;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            double c = a % b* 1.0 / b;
            Console.WriteLine(a / b + c);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.ReadLine(); 
        }
    }
}
