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
                return path.Length;
        }
        public static void Main(string[] args)
        {
            String path = @"./assets/lorem-ipsum.txt";
            Console.WriteLine(CountLines(path));
            Console.ReadLine();
        }
    }
}
