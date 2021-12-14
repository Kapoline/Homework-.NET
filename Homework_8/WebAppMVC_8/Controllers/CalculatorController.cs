using Microsoft.AspNetCore.Mvc;
using WebAppMVC_8.Calculator;

namespace WebAppMVC_8.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculator _calculator;
        private readonly IParser _parser;

        public CalculatorController(ICalculator calculator, IParser parser)
        {
            _calculator = calculator;
            _parser = parser;
        }
        

        [HttpGet, Route("Calculate")]
        public IActionResult Calculate(string var1, string var2, string operation)
        {
            var _operation = _parser.ParseOperator(operation);
            var term1 = _parser.ParseArguments(var1, out var var11);
            var term2 = _parser.ParseArguments(var2, out var var22);
            var result = _calculator.Calculate(term1, term2, _operation);
            if (result == -1)
                return BadRequest("UnknownOperation");
            return Ok(result);
        }
    }
    
}