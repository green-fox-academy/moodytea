using System;
using System.IO;

namespace Countline
{
    class Program
    {
        public static int CountLines (string path)
        {
            if (path == "")
                return 0;
            else
                for (int i = 0; i < path.Length; i++)
                {
                    if (path.Contains("/n"))
                    {
                        int counter = 0;
                        counter += 1;
                        return counter;
                    }
                    

                }
            return 404;
        }
        public static void Main(string[] args)
        {
            String path = @"./assets/lorem-ipsum.txt";
            Console.WriteLine(CountLines(path));
            Console.ReadLine();
        }
    }
}
