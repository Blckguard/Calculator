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
    }
}
