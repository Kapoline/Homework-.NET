namespace Homework_1
{
    public class Parser
    {
        public static bool IsInt(string num1, out int num11)
        {
            if (int.TryParse(num1, out num11))
                return true;
            else
            {
                return false;
            }
        }
        
        public static Calculator.operations OperationDetector(string arg)
        {
            Calculator.operations operation;
            switch (arg)
            {
                case "+":
                    operation = Calculator.operations.Plus;
                    break;
                case "-":
                    operation = Calculator.operations.Minus;
                    break;
                case "*":
                    operation = Calculator.operations.Mult;
                    break;
                case "/":
                    operation = Calculator.operations.Divide;
                    break;
                default:
                    operation = Calculator.operations.UnknownOperation;
                    break;
            }
            return operation;
        }
    }
}