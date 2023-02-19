using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace StringManipulationChallenge
{
    public static class Helper
    {
        public static void Encode(string input)
        {
            string toEncode;
            StringBuilder stringbuilder = new StringBuilder(input);
            int firstStringLength = stringbuilder.Length / 2;
            int secondStringLength = stringbuilder.Length - firstStringLength;
            char[] A = new char[firstStringLength];
            char[] B = new char[secondStringLength];
            stringbuilder.CopyTo(0, A, 0, firstStringLength);
            stringbuilder.CopyTo(firstStringLength, B, 0, secondStringLength);

            string[] outcome = new string[] {new string(A), new string(B)};

            string newA = "";
            string newB = "";

            for (int i = 0; i < firstStringLength; i++)
            {
                if(i % 2 == 0)
                {
                    newA += A[i] + "" +  B[i];
                }
                else
                {
                    newB += A[i] + "" + B[i];
                }
            }

            toEncode = newB + newA;
            Console.WriteLine(toEncode);

            Console.WriteLine(newA + newB);

            /*StringBuilder sb = new StringBuilder(toEncode);
            int decodeFirstLen = sb.Length / 2;

            int decodeSecondLen = sb.Length - decodeFirstLen;
            char[] decodedfirstStr = new char(decodedFirstLen);
            char[] decodedSecondStr = new char(decodeSecondLen);
            stringbuilder.CopyTo(0, decodedfirstStr, 0, decodedFirstLen);
            stringbuilder.CopyTo(decodedFirstLen, decodedSecondStr, 0, decodeSecondLen);
            string[] decodedResult = new string[] {new string(decodedfirstStr), new string(decodedSecondStr)};

            foreach (var item in decodedResult)
            {
                Console.WriteLine(item);
            }*/


        }
    }
}