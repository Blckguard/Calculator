using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Calculator
    {
        public static int AddNumbers(List<int> numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }
        public static int SubtractNumbers(List<int> numbers)
        {
            int result = numbers[0];
            
            for (int i = 1; i < numbers.Count(); i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static int MultiplyNumbers(List<int> numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Count(); i++)
            {
                result = result * numbers[i];
            }
            return result;
        }
    }
}
