namespace Home_work_1
{
    public class Parser
    {
        public static bool IsInt(string num1, out int num2)
        {
            if (int.TryParse(num1, out num2))
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