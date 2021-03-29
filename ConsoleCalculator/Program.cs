using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1, operand2;
            char operation;

            Console.WriteLine("Введите первое число: ");
            operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            operand2 = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine("Ваш результат " + Sum(operand1, operand2));
            }
            else if (operation == '-')
            {
                Console.WriteLine("Ваш результат " + Difference(operand1, operand2)); 
            }
            else if (operation == '*')
            {
                Console.WriteLine("Ваш результат " + Multiplication(operand1, operand2));
            }
            else if (operation == '/')
            {
                Console.WriteLine("Ваш результат " + Division(operand1, operand2)); 
            }
            else
                Console.WriteLine("Вы ввели неправильный знак");
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
