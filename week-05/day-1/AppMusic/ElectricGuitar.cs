using System;
using System.Collections.Generic;
using System.Text;

namespace AppMusic
{
    class ElectricGuitar : StringInstrument
    {
        public ElectricGuitar()
        {
            Name = "Electric Guitar";
            NumberOfStrings = 6;
            Noise = "twangs";
        }

        public ElectricGuitar(int numberOfStrings)
        {
            Name = "Electric Guitar";
            NumberOfStrings = numberOfStrings;
            Noise = " twangs";
        }

    }
}
