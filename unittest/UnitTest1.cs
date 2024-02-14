using calculatorlib;
namespace unittest;

public class UnitTest1
{
    [Theory]
    [InlineData("1" , "5" , "6")]
    [InlineData("3" , "4" , "7")]
    [InlineData("-1" , "4" , "3")]
    [InlineData("-2" , "4" , "2")]
    [InlineData("4" , "4" , "8")]
    public void AddTest(string n1 , string n2 , string e)
    {
        decimal number1 = decimal.Parse(n1);
        decimal number2 = decimal.Parse(n2);
        decimal expectedResult = decimal.Parse(e);
       var result = CalculatorOperator.Add(number1 , number2);
       Assert.Equal(expectedResult , result); 
    }
     [Theory]
    [InlineData("4" , "1" , "3")]
    [InlineData("4" , "4" , "0")]
    [InlineData("14" , "4" , "10")]
    [InlineData("8" , "4" , "4")]
    [InlineData("10" , "4" , "6")]
    public void SubtractTest(string n1 , string n2 , string e)
    {
        decimal number1 = decimal.Parse(n1);
        decimal number2 = decimal.Parse(n2);
        decimal expectedResult = decimal.Parse(e);
       var result = CalculatorOperator.Subtract(number1 , number2);
       Assert.Equal(expectedResult , result); 
    }
     [Theory]
    [InlineData("4" , "1" , "4")]
    [InlineData("4" , "4" , "16")]
    [InlineData("10" , "4" , "40")]
    [InlineData("2" , "4" , "8")]
    [InlineData("3" , "4" , "12")]
    public void MultiplyTest(string n1 , string n2 , string e)
    {
        decimal number1 = decimal.Parse(n1);
        decimal number2 = decimal.Parse(n2);
        decimal expectedResult = decimal.Parse(e);
       var result = CalculatorOperator.Multiply(number1 , number2);
       Assert.Equal(expectedResult , result); 
    }
     [Theory]
    [InlineData("10" , "2" , "5")]
    [InlineData("4" , "4" , "1")]
    [InlineData("16" , "4" , "4")]
    [InlineData("20" , "2" , "10")]
    [InlineData("20" , "4" , "5")]
    public void DivideTest(string n1 , string n2 , string e)
    {
        decimal number1 = decimal.Parse(n1);
        decimal number2 = decimal.Parse(n2);
        decimal expectedResult = decimal.Parse(e);
       var result = CalculatorOperator.Divide(number1 , number2);
       Assert.Equal(expectedResult , result); 
    }
}