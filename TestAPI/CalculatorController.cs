using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace MyApp.Namespace
{
    [Route("[Controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public string Test(){
            return "Test";
        }

        [HttpGet]
        public decimal Add(decimal number1, decimal number2)
        {  
           decimal sum = number1 + number2;
            return sum;
        }
        
        [HttpGet]
        public decimal Subtract(decimal number1, decimal number2)
        {  
           decimal subractResult = number1 - number2;
            return subractResult;
        }
        [HttpGet]
        public decimal Multiply(decimal number1, decimal number2)
        {  
           decimal MulResult = number1 * number2;
            return MulResult;
        }
        [HttpGet]
        public decimal Divide(decimal number1, decimal number2)
        {  
           decimal DivResult = number1 / number2;
            return DivResult;
        }
        [HttpGet]
        public decimal Modulo(decimal number1, decimal number2)
        {  
           decimal ModResult = number1 % number2;
            return ModResult;
      }

}
}