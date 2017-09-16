using System;
using System.Collections.Generic;


namespace square1
{
    class Program
    {
        static void Main(string[] args)
		{
			Console.WriteLine("Enter a number!");
			int n = int.Parse(Console.ReadLine());

            int i;
            string S = "";
            for (i = 1; i <= n; i++ ){
                S = S + "%";
            }

            Console.WriteLine(S);

            S = "%";

            for (i = 2; i <= n - 1; i++)
            { S += " "; }

            S += "%";

            for (i = 2; i <= n - 1; i++){
                Console.WriteLine(S);
            }

            S = "";

			for (i = 1; i <= n; i++)
			{
				S = S + "%";
			}
            Console.WriteLine(S);


            Console.ReadLine();
        }
    }
}
