using System;
using System.Collections.Generic;
using System.Text;

namespace AppMusic
{
    class BassGuitar : StringInstrument
    {
        public BassGuitar()
        {
            Name = "Bass Guitar";
            NumberOfStrings = 4;
            Noise = "Duum-duum-duum";
        }
        public BassGuitar(int numberOfStrings)
        {
            Name = "Bass Guitar";
            NumberOfStrings = numberOfStrings;
            Noise = "Duum-duum-duum";
        }
    }
}
