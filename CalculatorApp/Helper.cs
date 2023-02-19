using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Helper
    {
        public static void Calculator()
        {
            int firstNum = 0;
            int secondNum = 0;
        
            try
            {
                bool flag = true;

                do
                {
                    Console.WriteLine("Enter your first operand: ");
                    firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose an operator: ");
                    Console.WriteLine(" + - Add ");
                    Console.WriteLine(" - - Subtract");
                    Console.WriteLine(" * - Multiply ");
                    Console.WriteLine(" / - Divide ");
                    Console.WriteLine(" % - Remainder ");
                    Console.WriteLine("Your Option: ");
                    string action = Console.ReadLine();
                    Console.WriteLine("Enter your second operand: ");
                    secondNum = int.Parse(Console.ReadLine());

                    switch(action.ToLower().Trim())
                    {
                        case "+":
                        case "add":
                        Console.WriteLine($" Your result: {firstNum} + {secondNum} = {firstNum + secondNum}");
                        break;

                        case "-":
                        case "subtract":
                        Console.WriteLine($" Your result: {firstNum} - {secondNum} = {firstNum - secondNum}");
                        break;

                        case "/":
                        case "divide":
                        Console.WriteLine($" Your result: {firstNum} / {secondNum} = {firstNum / secondNum}");
                        break;

                        case "*":
                        case "multiply":
                        Console.WriteLine($" Your result: {firstNum} * {secondNum} = {firstNum * secondNum}");
                        break;

                        case "%":
                        case "modulo":
                        Console.WriteLine($" Your result: {firstNum} % {secondNum} = {firstNum % secondNum}");
                        break;

                        default:
                        Console.WriteLine("Invalid operator!");
                        break;

                    }
                    
                    string option = string.Empty;

                    do
                    {
                        Console.WriteLine("Do you want to perform another calculation?:(Y for Yes/N for No)");
                        option = Console.ReadLine().ToLower();

                    } while (!(option.Equals("y".ToLower())) && !(option.Equals("n".ToLower())));

                 flag = option.Equals("y".ToLower());
                 if(!flag)
                 {
                    Console.WriteLine("Thank you for using our app!");
                 }

                } while(flag);

            }
            catch(Exception ex)   
            { 
                Console.WriteLine("Your input is invalid!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}