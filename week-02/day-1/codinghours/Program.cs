using System;

namespace ex6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Greenfox coding hours calculator!");
            Console.ReadLine();
            int hours = 6;
            int days = hours * 5;
            int weeks = days * 18;
            double percent = (weeks / (52.0*18))*100;
            Console.WriteLine("Calculating with the average, your weekly coding results to: " + weeks + " hrs! That's "+ percent +"% of your working hours. Unbelievabe, isn't it?" );


            Console.ReadLine();
        }
    }
}
