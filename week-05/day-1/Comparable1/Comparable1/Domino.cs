using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable1
{
    class Domino : IComparable<Domino>, IPrintable
    {

        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int GetValueA()
        {
            return GetValues()[0];
        }

        public int GetValueB()
        {
            return GetValues()[1];
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(Domino other)
        {
            
            // Alphabetic sort if salary is equal. [A to Z]
            if (other.GetValueB() == this.GetValueB())
            {
                return other.GetValueA().CompareTo(this.GetValueA());
            }
            // Default to salary sort. [High to low]
            return this.GetValueB().CompareTo(other.GetValueB());
        }

        public override string ToString()
        {
            return this.GetValueB() + "," + this.GetValueA();
        }

        public void PrintAllFields()
        {
            foreach (var element in Program.dominoes)
            {
                Console.WriteLine(element);
            }
        }
    }
}
