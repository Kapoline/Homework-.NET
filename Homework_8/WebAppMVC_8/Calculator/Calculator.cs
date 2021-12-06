using System;

namespace WebAppMVC_8.Calculator
{
    public class Calculator : ICalculator
    {
        public enum Operations
        {
            Plus,
            Minus,
            Mult,
            Divide,
            UnknownOperation
        }
        public int Calculate(int var1, int var2,Operations operation)
        {
            var result = operation switch
            {
                Operations.Plus => var1 + var2,
                Operations.Minus => var1 - var2,
                Operations.Mult => var1 * var2,
                Operations.Divide => var1 / var2,
                _ => -1
            };
            return result;
        }
    }
}