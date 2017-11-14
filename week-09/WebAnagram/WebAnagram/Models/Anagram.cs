using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAnagram.Models
{
    public class Anagram
    {
        public Anagram()
        {

        }

        public bool Are = false;

        public void AreThey(string s1, string s2)
        {
            char[] a1 = s1.ToLower().ToArray();
            Array.Sort(a1);
            s1 = new string(a1);

            char[] a2 = s2.ToLower().ToArray();
            Array.Sort(a2);
            s2 = new string(a2);


            if (!s1.Equals(s2))
            {
                Are = false;
            }
            else
            {
                Are = true;
            }
        }
    }
}
