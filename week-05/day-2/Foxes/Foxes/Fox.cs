using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foxes
{
    class Fox
    {
        public string Name { get; set; } = "fox";
        public string Type { get; set; } = "alpaga";
        public string Color { get; set; } = "green";

        public Fox (string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

       
    }
}
