using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class Helper
    {
        public static string Encode(string input)
        {
            // Check that the input string is at least 10 characters long
            if (input.Length < 10)
            {
                throw new Exception("Input string must be at least 10 characters long.");
            }

            // Divide the input string into substrings A and B
            int midpoint = input.Length / 2;
            string A = input.Substring(0, midpoint);
            string B = input.Substring(midpoint);

            // Traverse substrings A and B and swap characters at even indexes of A with those at odd indexes of B
            char[] encoded = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    encoded[i] = B[i / 2];
                }
                else
                {
                    encoded[i] = A[i / 2];
                }
            }

            // Return the encoded string
            return new string(encoded);
        }
      //  This code divides the input string into two substrings of roughly equal length, then traverses both substrings and swaps the characters at the specified indexes as described in the problem statement. The encoded string is then returned.

        public static string Decode(string input)
        {
            
            int midpoint = input.Length / 2;
            string newA = input.Substring(0, midpoint);
            string newB = input.Substring(midpoint);

            // Traverse substrings NEW and ANEWB and swap characters at even indexes of NEW with those at odd indexes of ANEWB
            char[] decoded = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    decoded[i] = newB[i / 2];
                }
                else
                {
                    decoded[i] = newA[i / 2];
                }
            }

            // Return the decoded string
            return new string(decoded);
        }  





    }
}