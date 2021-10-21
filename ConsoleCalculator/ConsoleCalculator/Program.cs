using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple console calculator!\n");
            Console.Write("Inout first operand: ");
            double firstOperand = Calc.NumInput();
            Console.WriteLine();

            Console.Write("Input perator (+ - * / % sqrt): ");
            bool isSecondNeed = Calc.OperatorInput(out string mathOperator);
            double secondOperand = 0;

            if (isSecondNeed == true)
            {
                Console.WriteLine("Input second operand: ");
                secondOperand = Calc.NumInput();
                Console.WriteLine();
            }
            double result = 0;

            switch (mathOperator)
            {
                case "+":
                    result = Calc.Add(firstOperand, secondOperand);
                    break;
                 case "-":
                    result = Calc.Subtract(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Calc.Multiply(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Calc.Divide(firstOperand, secondOperand);
                    break;
                case "%":
                    result = Calc.RestOfDivide(firstOperand, secondOperand);
                    break;
                //case "sqrt":
                //    result = Calc.Add(firstOperand, secondOperand);
                //    break;
                //case "!":
                //    result = Calc.Add(firstOperand, secondOperand);
                //    break;



                default:
                    Console.WriteLine("No such operator :( ");
                    break;
            }
            Console.WriteLine($"Your result is: {result}");
        }
    }
}
