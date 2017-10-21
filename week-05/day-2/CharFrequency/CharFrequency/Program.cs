using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string madeForThis = "Katona Anotak D";

            var groups = madeForThis.GroupBy(x => char.ToLower(x)).Select(x => new { Letter = x.Key, Count = x.Count() }).ToList();
            foreach (var item in groups)
            {
                Console.Write(item);
            }
           
        }
    }
}
