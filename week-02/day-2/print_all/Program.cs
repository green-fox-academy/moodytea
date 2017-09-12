using System;

namespace print_all
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `af`
            int[] af = { 4, 5, 6, 7 };
            //int first = af[1];
            //int last = af[af.Length]; 
            //Console.WriteLine(first>last);
            foreach (int element in af)
                Console.WriteLine(element);

            Console.ReadLine();
        }
    }
}
