using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using calculatorlib;
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
            return CalculatorOperator.Add(number1 , number2);
        }
        
        [HttpGet]
        public decimal Subtract(decimal number1, decimal number2)
        {  
         
            return CalculatorOperator.Subtract(number1 , number2);
        }
        [HttpGet]
        public decimal Multiply(decimal number1, decimal number2)
        {  
            return CalculatorOperator.Multiply(number1 , number2);
        }
        [HttpGet]
        public decimal Divide(decimal number1, decimal number2)
        {  
          
            return CalculatorOperator.Divide(number1 , number2);
        }
        [HttpGet]
        public decimal Modulo(decimal number1, decimal number2)
        {  
         
            return CalculatorOperator.Modulo(number1 , number2);
      }

}
}