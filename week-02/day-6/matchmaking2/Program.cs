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



			int Diff = boys.Count - girls.Count;
            if (Diff == 0){
				for (int i = 0; i < boys.Count; i++)
				{
					order.Add(girls[i]);
					order.Add(boys[i]);
				}
                order.ForEach(Console.WriteLine);
            }
			else if (Diff > 0)
			{
                for (int i = 0; i < boys.Count-Diff ; i++)
				{
					order.Add(girls[i]);
					order.Add(boys[i]);

				}
                order.ForEach(Console.WriteLine);
				Console.WriteLine(boys[boys.Count - Diff]);
			}
			else if (Diff < 0)
			{
                for (int i = 0; i < girls.Count-Diff; i++)
				{
					order.Add(girls[i]);
					order.Add(boys[i]);

				}
                order.ForEach(Console.WriteLine);
				Console.WriteLine(girls[girls.Count - Diff]);
			}


		
			// Join the two lists by matching one girl with one boy in the order list
			// Exepected output: "Eve", "Joe", "Ashley", "Fred"...

			Console.WriteLine();
		}
	}
}
