using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNaturalClasses
{
    class Winchester : TFW
    {
        private int killcount;
        private string weapon;

        public Winchester (string name, int age, string race, string weapon)
        {
            this.name = name;
            this.age = age;
            this.race = race;
            this.weapon = weapon;
            this.killcount = 102;
        }

        public Winchester()
        {
            this.name = "Sam";
            this.age = 33;
            this.race = "hunter";
            this.weapon = "Ruby's knife";
            this.killcount = 54;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: To save my brother!");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} with a {3} who killed {4} " +
                "monsters.", this.name, this.age, this.race, this.weapon, this.killcount);
        }

        public void MonsterCount(int newkillcount)
        {
           killcount += newkillcount;
        }
    }
}
