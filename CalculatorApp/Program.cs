using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
           /* CalculatorEngine engine = new CalculatorEngine();
            InputConverter convert = new InputConverter();
            try
            {
                Console.WriteLine("Enter first number: ");
                int firstNum = convert.ConvertToNumeric(Console.ReadLine());

                Console.WriteLine("Enter operator: ");
                string action = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                int secondNum = convert.ConvertToNumeric(Console.ReadLine());

                Console.WriteLine($"Your result is: {engine.Calculate(firstNum,action,secondNum)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            Helper.Calculator();
           
        }
    }
}
