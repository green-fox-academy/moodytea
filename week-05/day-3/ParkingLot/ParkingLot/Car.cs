using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParkingLot
{
    class Car
    {
        static Random randy = new Random((int)DateTime.Now.Millisecond);
        public string Type;
        public string Color;
        protected static int carIDCounter = 1;

        public Car()
        {
            Type = RandomType().ToString();
            Color = RandomColor().ToString();
        }
        
        public enum TypeList
            {
                Impala,
                Toyota,
                Ferrari,
                Mercedes

            }

        private TypeList RandomType()
        {
            
            return (TypeList)randy.Next(0, Enum.GetNames(typeof(TypeList)).Length);

        }

        public enum ColorList 
            {
                DeepPurple,
                NeonPink,
                MetalShine,
                PearlyWhite,
                FeverYellow

            }
        private ColorList RandomColor()
        {
            
            return (ColorList)randy.Next(0, Enum.GetNames(typeof(ColorList)).Length);

        }
        

    }
}
