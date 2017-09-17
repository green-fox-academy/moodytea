using System;
using System.Collections.Generic;

namespace elementfinder
{
    class Program
    {
        static void Main(string[] args)
        {
			var List = new List<int> { 1, 2, 3, 4, 5 };

			// Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
			// Do this again with a different solution using different list functions!

			//myFirstSolution:
			//if (List.Contains(7)){
			//Console.WriteLine("Hoorray");
			//}
			// else
			//Console.WriteLine("Noooooo");

			//and the second:
            /* first solution:
             if (List.Contains(7))
			{
				Console.WriteLine("Hoorray");
			}
			else
			{
				Console.WriteLine("Noooooo");
			}*/

			
            int i = 0;
            while ( i < List.Count && List[i]!=7){
                i++;
                }
			if (i == List.Count)
			{
                Console.WriteLine("Noooooo");
            }
            else
			{
				Console.WriteLine("Hoorray");
			}
            Console.ReadLine();
                   
		}
    }
}
