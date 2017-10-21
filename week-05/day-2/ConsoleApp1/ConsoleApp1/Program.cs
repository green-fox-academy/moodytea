using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string madeForThis = "LaughingOutLoud";

            IEnumerable<char> sMadeForThis =
                from i in madeForThis
                where char.IsUpper(i) == true
                select i;
            foreach (var item in sMadeForThis)
            {
                Console.Write(item);
            }

            var sMadeForThis2 = madeForThis.Where(c => char.IsUpper(c));
            foreach (var item in sMadeForThis2)
            {
                Console.Write(item);
            }
        }
    }
}
