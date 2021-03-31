using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program.Calc;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the Operator: ");
            string op = Console.ReadLine();
            if(op == "+")
            {
                Console.Write("Type in the first number: ");
                string num1 = Console.ReadLine();
                int number = Int32.Parse(num1);
                Console.Write("Type in the second number: ");
                string num2 = Console.ReadLine();
                int number2 = Int32.Parse(num2);
                int result = Calculator.Add(number, number2);
                Console.WriteLine(result);
            }
            else if(op == "-")
            {
                Console.Write("Type in the first number: ");
                string num1 = Console.ReadLine();
                int number = Int32.Parse(num1);
                Console.Write("Type in the second number: ");
                string num2 = Console.ReadLine();
                int number2 = Int32.Parse(num2);
                int result = Calculator.Minus(number, number2);
                Console.WriteLine(result);

            }
            else if(op == "*")
            {
                Console.Write("Type in the first number: ");
                string num1 = Console.ReadLine();
                int number = Int32.Parse(num1);
                Console.Write("Type in the second number: ");
                string num2 = Console.ReadLine();
                int number2 = Int32.Parse(num2);
                int result = Calculator.Multi(number, number2);
                Console.WriteLine(result);
            }
            else if(op == "/")
            {
                Console.Write("Type in the first number: ");
                string num1 = Console.ReadLine();
                int number = Int32.Parse(num1);
                Console.Write("Type in the second number: ");
                string num2 = Console.ReadLine();
                int number2 = Int32.Parse(num2);
                int result = Calculator.Div(number, number2);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
