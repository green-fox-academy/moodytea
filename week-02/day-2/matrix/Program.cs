using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int[ , ] myArray = new int[4, 4];
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    myArray [i,j] = (i==j) ? 1 : 0;
                }
            }
			for (int i = 0; i <= 3; i++)
			{
				for (int j = 0; j <= 3; j++)
				{
                    Console.Write( myArray [i , j]);
                }
                Console.WriteLine("");
			}

            Console.ReadLine();
        }
    }
}
