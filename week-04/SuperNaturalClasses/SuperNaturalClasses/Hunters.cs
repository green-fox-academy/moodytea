using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNaturalClasses
{
    class SupernaturalBeings
    {
        private string className;
        private List<Angel> angels = new List<Angel>();
        private List<Demon> demons = new List<Demon>();

        public SupernaturalBeings()
        {
            this.className = "Supernatural Beings"; 
            this.angels = angels;
            this.demons = demons;
        }

        public void AddAngel(Angel angel)
        {
            angels.Add(angel);
        }

        public void AddDemon(Demon demon)
        {
            demons.Add(demon);
        }

        public void Info()
        {
            Console.WriteLine(" {0} class has {1} demons and {2} angels.", this.className,
                this.demons.Count, this.angels.Count);
        }
    }
}
