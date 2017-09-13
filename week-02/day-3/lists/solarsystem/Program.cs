using System;

namespace solarsystem
{
    class Program
    {
        static void Main(string[] args)
        {
			var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
			"Neptune" };


			// Saturn is missing from the planetList
			// Insert it into the correct position

			Console.WriteLine(planetList);
        }
    }
}
