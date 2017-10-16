using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    abstract class Plant
    {
        public static readonly string[] ColorOfPlant = { "cottonCandyPink", "skyBlue", "deepPurple", "flamingRed", "feverYellow" };
        protected static Random random = new Random();

        private string _zeColorOfPlant = ColorOfPlant[random.Next(ColorOfPlant.Length)];
        private string _typeOfPlant;
        private int _waterLimit;
        private double _waterConsumption;

        public Plant (string type, string color, int waterlim, double watercon)
        {
            _zeColorOfPlant = color;
            _typeOfPlant = type;
            _waterLimit = waterlim;
            _waterConsumption = watercon;
        }

        public void Water()
        {
        }

        public void DoesItNeedWater()
        {
            Console.WriteLine($"The {color} {type} {(NeedsWatering() ? "needs" : "doesn't need")} water";);
        }

    }

}

