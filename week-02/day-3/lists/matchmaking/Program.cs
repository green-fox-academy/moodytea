using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            int sizeOfList = girls.Count;
		
            for (int i = 0; i < sizeOfList; i++)
            {
                Console.WriteLine(string.Concat(girls[i]," ", boys[i]));
            }

            int Diff = boys.Count - girls.Count;


            if (Diff>0){
                Console.WriteLine(boys[boys.Count-Diff]);
            }
			if (Diff<0)
			{
                Console.WriteLine(girls[sizeOfList - Diff]);
			}

			
        
        // Join the two lists by matching one girl with one boy in the order list
        // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

        Console.WriteLine();
        }
    }
}
