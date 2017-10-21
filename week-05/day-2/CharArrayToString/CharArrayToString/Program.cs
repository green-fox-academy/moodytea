using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] madeForThis = new string[] { "Hel","lo",", dear!"};

            
            string sMadeForThis2 = string.Join("", madeForThis);
            string sMadeForThis1 = string.Concat(madeForThis);

            Console.WriteLine(sMadeForThis2);
            Console.WriteLine(sMadeForThis1);
        }
    }
}
