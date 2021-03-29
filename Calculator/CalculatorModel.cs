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
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / (double)operand2;
                default:
                    return null;
            };
        }

        
    }
}
