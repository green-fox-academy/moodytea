using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./new-text.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("My name is Dorothy Katona.");
                }
            }
            catch
            {
                Console.WriteLine("Couldn't write file!");
            }
            Console.ReadLine();
        }
    }
}