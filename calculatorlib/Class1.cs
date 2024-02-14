namespace calculatorlib;

public static class CalculatorOperator
{    
        public static  decimal Add(decimal number1, decimal number2)
        {  
           decimal AddResult = number1 + number2;
            return AddResult;
        }
        
        
        public static  decimal Subtract(decimal number1, decimal number2)
        {  
           decimal subractResult = number1 - number2;
            return subractResult;
        }
        
        public static decimal Multiply(decimal number1, decimal number2)
        {  
           decimal MultiplyResult = number1 * number2;
            return MultiplyResult;
        }
        
        public static decimal Divide(decimal number1, decimal number2)
        {  
           decimal DivideResult = number1 / number2;
            return DivideResult;
        }
       
        public static decimal Modulo(decimal number1, decimal number2)
        {  
           decimal ModuloResult = number1 % number2;
            return ModuloResult;
      }

}

