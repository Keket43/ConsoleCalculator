using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calc
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        // а раньше мы так писали:      
        //  double res = n1 + n2;
        //return res;

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.WriteLine("Can not divide by zero!");
                return 0;
            }
            return x / y;
        }


        public static double RestOfDivide(double x, double y)
        {
            return x % y;
        }

        public static double Sqrt(double num, double sqrt) //квадратный корень
        {
            return Math.Sqrt(num);
        }

       
        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoublleInput = double.TryParse(numberString, out double numberDouble);

            while (!isDoublleInput)
            {
                Console.Write("Wrong input! Tru again: ");
                numberString = Console.ReadLine();
                isDoublleInput = double.TryParse(numberString, out numberDouble);
            }
            //парсинг и валидация
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator)
        {
            mathOperator = Console.ReadLine();
            List<string> operatorWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorWithOneArgument = new List<string> { "sqrt", "!" };

            while (true)
            {
                if (operatorWithSecondArgument.Contains(mathOperator))
                {
                    return true; //нужно спросить второе число
                }
                else if (operatorWithOneArgument.Contains(mathOperator))
                {
                    return false; //ввод второго числа пропускаем
                }
                Console.WriteLine();
                Console.Write("Wrong input! Try again: ");
            }
        }
    }
}
