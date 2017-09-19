using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Uh-oh, could not read the file!");
            }

            Console.ReadLine();
        }
    }
}