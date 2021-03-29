using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {

        }

        public object Calculate(int operand1, int operand2, char operation)
        {

            switch (operation)
            {
                case '+':
                    return Sum(operand1, operand2);
                case '-':
                    return Difference(operand1, operand2);
                case '*':
                    return Multiplication(operand1, operand2);
                case '/':
                    return Division(operand1, operand2);
                default:
                    return null;
            }




        }
        static private int Sum(int operand1, int operand2)
          {
            int sum = operand1 + operand2;
            return sum;
          }

        static private int Difference(int operand1, int operand2)
          {
            int dif = operand1 - operand2;
            return dif;
          }
        static private int Multiplication(int operand1, int operand2)
          {
            int mul = operand1 * operand2;
            return mul;
          }
        static private double Division(int operand1, int operand2)
        {
            double div = (double)operand1 / (double)operand2;
            return div;
        }
    }
}
