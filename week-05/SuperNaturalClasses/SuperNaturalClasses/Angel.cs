using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNaturalClasses
{
    class Angel : TFW
    {
        private string status;
        private int timesBeenDissapointed;

        public Angel(string name, int age, string status)
        {
            this.name = name;
            this.age = age;
            this.race = "angel";
            this.status = status;
            this.timesBeenDissapointed = 10;
        }

        public Angel()
        {
            this.name = "Lucifer";
            this.age = 4000;
            this.race = "angel";
            this.status = "fallen";
            this.timesBeenDissapointed = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old who is a {2} {3} and been dissapointed {4}"
                + "times so far.",
                this.name, this.age, this.status, this.race, this.timesBeenDissapointed);
        }

        public void Dissapoint()
        {
            timesBeenDissapointed++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Help hunters save or destroy the world.");
        }
    }
}
