using System;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
			// Print the Body mass index (BMI) based on these values
			double massInKg = 82.0;
			double heightInM = 1.90;
            double BMI = massInKg / (heightInM *= heightInM);


            Console.WriteLine(BMI);
            Console.ReadLine();
        }
    }
}
