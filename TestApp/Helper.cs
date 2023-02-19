using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp
{
    public static class Helper
    {
        public static void MultiplicationTable()
        {
            Console.Write("Enter the number to get the multiplication for:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter number of times:");
            int times = int.Parse(Console.ReadLine());
            
            PrintMultiplicationTable(number , times);
            
            static void PrintMultiplicationTable(int number, int times)
            {
                for(int i = 1; i <= times; i++)
                {
                    
                    Console.WriteLine($"{number} * {i} = {number * i}");
                    
                }
        
            }

        }
    }
}