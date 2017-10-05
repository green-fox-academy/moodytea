using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNaturalClasses
{
    class Demon : TFW
    {
        private string powerLevel;

        public Demon(string name, int age, string powerLevel)
        {
            this.name = name;
            this.age = age;
            this.race = "demon";
            this.powerLevel = powerLevel;
        }
        public Demon()
        {
            this.name = "Abbadon";
            this.age = 400;
            this.race = "demon";
            this.powerLevel = "powerful and";
        }
        public override void GetGoal()
        {
            Console.WriteLine("My goal is: to save myself and create chaos!");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who is a {3} " +
                "strong demon.", this.name, this.age, this.race, this.powerLevel);
        }
    }
}
