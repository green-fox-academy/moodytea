using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        [Required(ErrorMessage = "This is a required field for the adoption!")]
        [MinLength(2, ErrorMessage ="The name of the fox should be at least two characters long!")]
        [MaxLength(25, ErrorMessage ="The name for your sweet little fox is too long!")]
        public string Name { get; set; }

        public SnacksAndTricks.Food Food { get; set; } 
        public SnacksAndTricks.Drink Drink { get; set; } 
        public SnacksAndTricks.Tricks Tricks { get; set; } 

        public Fox()
        {
        }
    }
}
