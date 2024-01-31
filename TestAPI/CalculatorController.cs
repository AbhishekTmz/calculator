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
           decimal AddResult = number1 + number2;
            return AddResult;
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
           decimal MultiplyResult = number1 * number2;
            return MultiplyResult;
        }
        [HttpGet]
        public decimal Divide(decimal number1, decimal number2)
        {  
           decimal DivideResult = number1 / number2;
            return DivideResult;
        }
        [HttpGet]
        public decimal Modulo(decimal number1, decimal number2)
        {  
           decimal ModuloResult = number1 % number2;
            return ModuloResult;
      }

}
}