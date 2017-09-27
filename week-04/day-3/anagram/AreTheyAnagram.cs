using System;
using System.Linq;
using System.Collections.Generic;

namespace anagram
{
    public class AreTheyAnagram
    {
        public static bool SoAreTheyAnagram(string s1, string s2)
		{
			char[] a1 = s1.ToLower().ToArray();
			Array.Sort(a1);
            s1 = new string(a1);

			char[] a2 = s2.ToLower().ToArray();
			Array.Sort(a2);
			s2 = new string(a2);

            if (!s1.Equals(s2))
			{
				return false;
			}
			else
			{
				return true;
			}
        }
    }
}
