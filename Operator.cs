using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Operator
    {
        private List<double> Numbers { get; set; }
        private List<string> Operators { get; set; }

        public Operator(List<double> numbers, List<string> operators)
        {
            Numbers = numbers;
            Operators = operators;
        }
    
        public static double Calculate()
        {
            foreach (string op in  Operators)
            {
                if (op == "+")
                {
                    double result = Addition.NewInstance().Calculate(Numbers[0], Numbers[1]);
                    Numbers[0] = result;
                    Numbers.RemoveAt(1);
                    continue;
                 }
                else if (op  == "-")
                {
                    double result = Subtraction.NewInstance().Calculate(Numbers[0], Numbers[1]);
                    Numbers[0] = result;
                    Numbers.RemoveAt(1);
                    continue;
                }
            }
            return Numbers[1];
        }


   }
}
