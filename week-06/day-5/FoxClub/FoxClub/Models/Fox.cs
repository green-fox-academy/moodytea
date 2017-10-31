using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public SnacksAndTricks.Food Food { get; set; } 
        public SnacksAndTricks.Drink Drink { get; set; } 
        public SnacksAndTricks.Tricks Tricks { get; set; } 

        public Fox()
        {
        }
    }
}
