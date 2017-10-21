using System;
using System.Collections.Generic;
using System.Text;

namespace AppMusic
{
    abstract class Instrument
    {
        protected string Name { get; set; } = "instrument";
        protected int NumberOfStrings { get; set; } = 3;
        protected string Noise { get; set; } = "makes sound";
        public abstract void Play();

    }
}
