using System;

namespace Home_work_1
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
        
        public static int Calculate(int var1, int var2, operations operation)
        {
            var result = 0;
            switch (operation)
            {
                case operations.Plus:
                    result = var1 + var2;
                    break;
                case operations.Minus:
                    result = var1 - var2;
                    break;
                case operations.Mult:
                    result = var1 * var2;
                    break;
                case operations.Divide:
                    if (var2 == 0)
                    {
                        throw DivideByZero;
                    }

                    result = var1 / var2;
                    break;
                case operations.UnknownOperation:
                    throw WrongOperator;
            }
            return result;
        }
    }
}