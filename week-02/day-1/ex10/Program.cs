using System;

namespace ex09
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, please tell us a few things about yourself!");
			String name;
			double age;
			double height;
			bool married;
			Console.WriteLine("What is your name?");
			name = Console.ReadLine();
			Console.WriteLine("Age?");
			age = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Height (in meters)?");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Are you married?");
			if (Console.ReadLine() == "yes")
			{
				married = true;
			}
			else
			{
				married = false;
			}
			Console.WriteLine("So! You are " + name + ", you are " + age + " years old, " + height + " meters tall, aaand it's " + married + " that you are married!");
		}
	}
}
