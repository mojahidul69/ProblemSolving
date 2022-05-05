using System;

namespace ProblemSolving
{
    public class CalculateStringOperation
    {
        public void StringOp()
        {
            Console.Write("First Number: ");
            float one = Convert.ToSingle(Console.ReadLine());

            Console.Write("Operator: ");
            string op = Console.ReadLine();

            Console.Write("Last Number: ");
            float two = Convert.ToSingle(Console.ReadLine());

            // If Statement
            if (op == "+")
            {
                Console.WriteLine("Result: " + (one + two));
            }
            else if (op == "-")
            {
                Console.WriteLine("Result: " + (one - two));
            }
            else if (op == "*")
            {
                Console.WriteLine("Result: " + (one * two));
            }
            else if (op == "/")
            {
                Console.WriteLine("Result: " + (one / two));
            }
            else if (op == "%")
            {
                Console.WriteLine("Result: " + (one % two));
            }
            else
            {
                Console.WriteLine("error!");
            }

            // Switch Case
            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (one + two));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (one - two));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (one * two));
                    break;
                case "/":
                    Console.WriteLine("Result: " + (one / two));
                    break;
                case "%":
                    Console.WriteLine("Result: " + (one % two));
                    break;
                default:
                    Console.WriteLine("Result: Invalid!");
                    break;
            }
        }
    }
}

/*CalculateStringOperation op = new CalculateStringOperation();
op.StringOp();
*/