using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Greens
    {
        double waterLevel;
        double waterInTake;
        string color;
        bool DoesItNeedWater;

        protected Greens(string color, double waterLevel, double waterInTake, bool DoesItNeedWater)
        {
            this.color = color;
            this.waterLevel = waterLevel;
            this.waterInTake = waterInTake;
            this.DoesItNeedWater = DoesItNeedWater;

        }
    }
}
