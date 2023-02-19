using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class InputConverter
    {
        public int ConvertToNumeric(string argsTextInput)
        {
            int convertedNumber;
            if(!int.TryParse(argsTextInput , out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }

            return convertedNumber;
        }
    }
}