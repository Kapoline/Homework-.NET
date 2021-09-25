using System;

namespace Homework_1
{
    public class Calculator
    {
        public enum operations
        {
            Plus,
            Minus,
            Mult,
            Divide,
            UnknownOperation,
        }

        public static Exception DivideByZero = new DivideByZeroException("can not divided by zero");
        public static Exception WrongOperator = new ArgumentException("this operator does not exist");



        public static int Calculate(int a, int b, operations operation)
        {
            var result = 0;
            switch (operation)
            {
                case operations.Plus:
                    result = a + b;
                    break;
                case operations.Minus:
                    result = a - b;
                    break;
                case operations.Mult:
                    result = a * b;
                    break;
                case operations.Divide:
                    if (b == 0)
                    {
                        throw DivideByZero;
                    }
                    result = a / b;
                    break;
                case operations.UnknownOperation:
                    throw WrongOperator;
            }
            return result;
        }
    }
}