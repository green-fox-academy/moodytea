using System;
using System.Collections.Generic;

namespace josephusproblem
{
    class Program
    {
        static void Main(string[] args)

        {
			Console.WriteLine("Enter the number!");
			int numberStart = int.Parse(Console.ReadLine());

            var numList = new List<int>();
            int number = 1;
            bool lastDead = true;

            while (number <= numberStart)
			{
                numList.Add(number);
                number++;
            }

            var length = numList.Count;

            while (length > 1)
            {
                if (length % 2 == 0 && lastDead)
                {
                    lastDead = true;
                    for (int i = length-1; i >= 1; i-=2)
                    {
                        numList.RemoveAt(i);
                    }

                }
				else if (length % 2 == 1 && lastDead)
				{
                    lastDead = false;
					for (int i = length - 2; i >= 1; i -= 2)
					{
						numList.RemoveAt(i);
					}

				}

				else if (length % 2 == 0 && !lastDead)
				{
                    lastDead = false;
					for (int i = length - 2; i >= 0; i -= 2)
					{
						numList.RemoveAt(i);
					}

				}

				else if (length % 2 == 1 && !lastDead)
				{
                    lastDead = true;
					for (int i = length - 1; i >= 0; i -= 2)
					{
						numList.RemoveAt(i);
					}

				}
            length = numList.Count;
            numList.ForEach(Console.Write);
            Console.WriteLine();
            }


            numList.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}
