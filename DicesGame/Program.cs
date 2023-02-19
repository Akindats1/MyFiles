using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;
using System;

namespace DicesGame
{
   class Program
   {
      static void Main(string[] args)
      {
        
      //   Exercise.DiceGame();
         Exercise.LoginChecker();
      
        Console.WriteLine("Enter a word: ");
        string input = Console.ReadLine();
        Console.WriteLine(Exercise.ReverseStringUsingRecursion(input));
      }
   }
}
