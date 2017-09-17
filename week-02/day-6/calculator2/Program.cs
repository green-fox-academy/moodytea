using System;

namespace calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a simple calculator application which reads the parameters from the prompt
			// and prints the result to the prompt.
			// It should support the following operations:
			// +, -, *, /, % and it should support two operands.
			// The format of the expressions must be: {operation} {operand} {operand}.
			// Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

			// You can use the Scanner class
			// It should work like this:

			// Start the program
			// It prints: "Please type in the expression:"
			// Waits for the user input
			// Print the result to the prompt
			// Exit
			Console.WriteLine("Please type in the expression:");

			string operation = Console.ReadLine();
			string num1 = Console.ReadLine();
			string num2 = Console.ReadLine();

			double num11 = Convert.ToInt64(num1);
			double num22 = Convert.ToInt64(num2);

            switch (operation){
            case "/":
				Console.WriteLine(num11 / num22);
                break;
			case "*":
				Console.WriteLine(num11 * num22);
			    break;
			case "+":
				Console.WriteLine(num11 + num22);
				break;
            case "-":
				Console.WriteLine(num11 - num22);
				break;
			case "%":
				Console.WriteLine(num11 % num22);
				break;
			}

			Console.Read();
		}
	}
}
