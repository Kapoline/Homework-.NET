using System;

namespace WebAppMVC_8.Calculator
{
    public class Parser : IParser
    {
        public int ParseArguments(string var1,out int var11)
        {
            var term1 = int.TryParse(var1,out var11);
            var term2 = int.TryParse(var1, out var11);
            if (!term1 || !term2)
                return 1;
            Calculator.Operations operations;
            
            
            return 0;
        }

        public Calculator.Operations ParseOperator(string args)
        {
            var operation = args switch
            {
                "+" => Calculator.Operations.Plus,
                "-" => Calculator.Operations.Minus,
                "*" => Calculator.Operations.Mult,
                "/" => Calculator.Operations.Divide,
                _ => Calculator.Operations.UnknownOperation
            };
            return operation;
        }
    }
}