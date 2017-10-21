using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable1
{
    class Program
    {
        static void Main(string[] args)
        {
            TFW john = new TFW("John Winchester", 40, "hunter");
            TFW johnTheClone = (TFW)john.Clone();
            johnTheClone.Introduce();
            Console.ReadKey();
        }
    }
}
