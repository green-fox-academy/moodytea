using System;
using System.Collections.Generic;

namespace AppendLetter
{
	public class AppendLetter
	{
		public static void Main(string[] args)
		{
            
			var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.
			List<string> far2 = new List<string>();
            for (int i = 0; i < far.Count; ++i)
			{
                far2.Add("a");
			}

            for (int i = 0; i < far.Count; i++)
            {
                Console.WriteLine(string.Concat(far[i], far2[i]));
            }


        }
	}
}