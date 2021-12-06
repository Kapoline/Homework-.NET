namespace WebAppMVC_8.Calculator
{
    public interface IParser
    {
        public int ParseArguments(string var1, out int var11);
        public Calculator.Operations ParseOperator(string args);
    }
}