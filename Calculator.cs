using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Calculator
    {
        private static int num1 { get; set; }
        private static int num2 { get; set; }
        private static string inputOperator { get; set; }

        private static void GetInput()
        {
            Console.Write("Type the first operand: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type the operator: ");
            inputOperator = Console.ReadLine();
            Console.Write("Type the second operand: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public static void CalculateOutput()
        {
            GetInput();

            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(Convert.ToInt32(num1 / num2));
                    break;
            }
        }
    }
}
