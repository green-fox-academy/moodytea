using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNaturalClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TFW> tfw = new List<TFW>();

            TFW charlie = new TFW("Charlie", 28, "human");
            tfw.Add(charlie);
            TFW kevin = new TFW();
            tfw.Add(kevin);
            Winchester dean = new Winchester("Dean Winchester", 37, "hunter", "Colt");
            tfw.Add(dean);
            Winchester sam = new Winchester();
            tfw.Add(sam);
            Demon crowley = new Demon("Fergus", 159, "quite");
            tfw.Add(crowley);
            Demon abbadon = new Demon();
            tfw.Add(abbadon);
            Angel cass = new Angel("Castiel", 234, "fallen");
            tfw.Add(cass);
            Angel lucy = new Angel();
            tfw.Add(lucy);

            foreach (TFW person in tfw)
            {
                person.Introduce();
                person.GetGoal();
            }

            SupernaturalBeings angelsAndDemons = new SupernaturalBeings();
            angelsAndDemons.AddAngel(cass);
            angelsAndDemons.AddAngel(lucy);
            angelsAndDemons.AddDemon(crowley);
            angelsAndDemons.AddDemon(abbadon);
            angelsAndDemons.Info();

            Console.ReadKey();
        }
    }
}
