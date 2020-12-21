using System;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            double Result;
            string Input1; string Input2;
            string Action;
            bool DoWhile = true;


            while(DoWhile)
            {
                Console.Clear();

                Console.WriteLine("Enter first number: ");
                Input1 = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                Input2 = Console.ReadLine();
                
                if(Double.TryParse(Input1, out double Number1) && Double.TryParse(Input2, out double Number2))
                {
                    Console.WriteLine("Select an option (+, -, *, /)");
                    Action = Console.ReadLine();

                    switch (Action)
                    {
                        case "+":
                            Result = Number1 + Number2;
                            Console.WriteLine("Your result is: " + Result);
                            break;

                        case "-":
                            Result = Number1 - Number2;
                            Console.WriteLine("Your result is: " + Result);
                            break;

                        case "*":
                            Result = Number1 * Number2;
                            Console.WriteLine("Your result is: " + Result);
                            break;

                        case "/":
                            if (Number2 == 0)
                            {
                                Console.WriteLine("You cannot divide by zero! ");
                            }

                            else
                            {
                                Result = Number1 / Number2;
                                Console.WriteLine("Your result is: " + Result);
                            }
                            break;

                        default:
                            Console.WriteLine("Please select a valid action! ");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue or N(n) to exit: ");

                    switch (Console.ReadLine())
                    {

                        case "n":
                        case "N":
                            DoWhile = false;
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Please, ");
                    Console.ReadLine();
                }
            }
            
        }
    }
}