using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            string[] m1 = { "x", "x","x","x" };
            for (int i = 0; i < 4; i++)
                Console.WriteLine(m1 + "/n");

            Console.ReadLine();
        }
    }
}
