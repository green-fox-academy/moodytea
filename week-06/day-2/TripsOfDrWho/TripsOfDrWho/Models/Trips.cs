using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripsOfDrWho.Models
{
    public class Trips
    {
        public string Name { get; set; } = "Doctor";
        public double Miles { get; set; } = 1000.00d;
        public bool IsGood { get; set; } = true;

        public Trips()
        {
        }

        public Trips(string name, bool isGood, double miles)
        {
            this.Name = name;
            this.IsGood = isGood;
            this.Miles = miles;
        }
    }
}
