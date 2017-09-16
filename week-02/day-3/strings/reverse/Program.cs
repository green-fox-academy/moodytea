using System;

namespace reverse
{
    class Program
    {

        static void Main(string[] args)
        {
			string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            // Try to solve this using ElementAt() first, and optionally anything else after.

            int counter = reversed.Length;

            for (int i = counter-1; i >=0; i-- ){
                Console.Write(Convert.ToString(reversed[i]));
            }




          
        }
    }
}
