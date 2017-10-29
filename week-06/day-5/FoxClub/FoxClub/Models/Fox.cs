using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; } = "Dean";
        public SnacksAndTricks.Food Food { get; set; } = SnacksAndTricks.Food.Pie;
        public SnacksAndTricks.Drink Drink { get; set; } = SnacksAndTricks.Drink.Beer;
        public SnacksAndTricks.Tricks Tricks { get; set; } = SnacksAndTricks.Tricks.protectSammy;
    }
}
