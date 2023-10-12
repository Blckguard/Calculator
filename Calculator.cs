using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{ 
    interface IMathOperation
    {
        double Calculate(double leftOperand, double rightOperand);
    }

    internal class Addition : IMathOperation
    {
        public static Addition NewInstance()
        {
            return new Addition();
        }
        public double Calculate(double leftOperand, double rightOperand)
        {
            return leftOperand + rightOperand;
        }
    }

    internal class Subtraction : IMathOperation
    {
        public static Subtraction NewInstance()
        {
            return new Subtraction();
        }
        public double Calculate(double leftOperand, double rightOperand)
        {
            return leftOperand - rightOperand;
        }
    }

    internal class Multiplication : IMathOperation
    {
        public double Calculate(double leftOperand, double rightOperand)
        {
            return leftOperand * rightOperand;
        }
    }

    internal class Division : IMathOperation
    {
        public double Calculate(double leftOperand, double rightOperand)
        {
            return leftOperand / rightOperand;
        }
    }
}
