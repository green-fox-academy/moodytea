using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AppMusic
{
    abstract class StringInstrument : Instrument
    {
        public StringInstrument() : this("no name", 3, "makes noise") { }

        public StringInstrument(string name, int numberOfStrings, string noise)
        {
            name = Name;
            numberOfStrings = NumberOfStrings;
            noise = Noise;
        }

        
        public override void Play()
        {
            // TODO readonly legyen itt
            string formatForPlay = $"{Name}, a {NumberOfStrings}-stringed instrument that {Noise}";
            Console.WriteLine(formatForPlay);
        }
       
    }
}
