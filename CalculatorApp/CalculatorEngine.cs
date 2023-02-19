using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorEngine
    {
        public int Calculate(int firstNum , string action, int secondNum)
        {
            int result;

            switch(action.ToLower().Trim())
            {
                case "+":
                case "add":
                result = firstNum + secondNum;
                break;

                case "-":
                case "subtract":
                result = firstNum - secondNum;
                break;

                case "/":
                case "divide":
                result = firstNum / secondNum;
                break;

                case "*":
                case "multiply":
                result = firstNum * secondNum;
                break;

                case "%":
                case "modulo":
                result = firstNum % secondNum;
                break;

                default:
                throw new InvalidOperationException("Invalid Operation");
                

            }

            return result;
        }
    }
}