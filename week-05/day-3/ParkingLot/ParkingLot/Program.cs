using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        private List<Car> carList = new List<Car>(200);
        
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            for (int i = 0; i < 257; i++)
            {
                cars.Add(new Car());
            }

            var groups = cars.GroupBy(x => x.Color).OrderByDescending(g => g.Count());
            foreach (var item in groups)
            {
                Console.WriteLine(item.Key.ToString() + " we have " + item.Count().ToString() + " times ");
            }

            var groups2 = cars.GroupBy(x => x.Type).OrderByDescending(g => g.Count());
            foreach (var item in groups2)
            {
                Console.WriteLine(item.Key.ToString() + " we have " + item.Count().ToString() + " times ");
            }

            var groups3 = cars.GroupBy(x => x.Type + " " + x.Color).OrderByDescending(g => g.Count());
            foreach (var item in groups3)
            {
                Console.WriteLine(item.Key.ToString() + " we have " + (item.Count().ToString() + " times "));
            }
            //var findCarColor = from i in cars
            //               where i.Color.Equals("green")
            //               select i;


        }
    }
}
