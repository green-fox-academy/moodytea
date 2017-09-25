using System;
using System.IO;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var NewText = @"./new-text.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter (NewText))
                {
                    writer.WriteLine("My name is Dorothy Katona.");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Couldn't write file!");
            }
            finally
            {
                Console.ReadLine();
            }
           
        }
    }
}