using System;
using System.Collections.Generic;
using System.Text;

namespace AppMusic
{
    class Violin : StringInstrument
    {
        public Violin()
        {
            string name = "Violin";
            int numberOfStrings = 4;
            string noise = "screeches";
            Name = name;
            NumberOfStrings = numberOfStrings;
            Noise = noise;
        }

        
    }
}
