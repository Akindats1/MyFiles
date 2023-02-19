using System;

namespace FreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
          


           /*string[] monthsName = {"January" , "February" , "March" , "April" , "May", "June" , "July" , "August" , "September" , "October" , "November" , "December"};
           int monthsLength = monthsName.Length;
           Console.WriteLine("Returns the number of months");
           Console.WriteLine($"The number of the months is :{monthsLength} months");
           Console.WriteLine();

           Console.WriteLine("Return the rank of the month");
           
           Console.WriteLine($"The rank of the month is: {monthsName.Rank} dimension");
            
            Console.WriteLine();

            Console.WriteLine("Reverse the months using loop");
            for(int i = monthsName.Length - 1; i >= 0; i--)
            {
              Console.WriteLine(monthsName[i]);
            }
            Console.WriteLine();

             Console.WriteLine("Reverse the months using array method");
             Array.Reverse(monthsName);
             foreach(string month in monthsName)
             {
               Console.WriteLine(month);
             }
              Console.WriteLine();
              Console.WriteLine("Sort the months in alphabetical order using array method");
             Array.Sort(monthsName);
             foreach(string months in monthsName)
             {
              Console.WriteLine(months);
             }
             Console.WriteLine();
              

             Console.WriteLine();

             Console.WriteLine("Copy the first six months to another loop");
             string [] firstSixMonths = new string[6];
             Array.Copy(monthsName, 0, firstSixMonths, 0, 6);
             foreach(string someMonths in firstSixMonths)
             {
              Console.WriteLine(someMonths);
             }
             Console.WriteLine();

             Console.WriteLine("Clone the months using array method.");
             string[] monthClone = (string[])monthsName.Clone();
             foreach(string element in monthClone)
             {
              Console.WriteLine(element);
             }
             //Console.Read();
             Console.WriteLine();

             Console.WriteLine("Clears months starting from index 6.");
             Array.Clear(monthsName ,6,6);
             foreach(string months in monthsName)
             {
              Console.WriteLine(months);
             }
             Console.WriteLine();
             Console.WriteLine("Clear all the months.");
             Array.Clear(monthsName , 0, monthsName.Length);
             foreach(string element2 in monthsName)
             {
              Console.WriteLine(element2);
             }*/
            
            
              
             
             
            
            
             /*Console.Write("\n\n");
             Console.Write("Display the cuberoot of the number\n");  
             Console.Write("------------------------------");  
             Console.Write("\n\n"); 
                
             Console.Write("Enter number:");
             double numberInput = int.Parse(Console.ReadLine());
             for(double i = 0; i <= numberInput; i++)
             {
              double result = i/3;
             
              Console.WriteLine($"The cuberoot of {i} = {Math.Round(result , 2)}");
             }*/




             Console.Write("\n\n");
             Console.Write("Display the cuberoot of the number\n");  
             Console.Write("----------------------------------");  
             Console.Write("\n\n");
             Console.Write("Enter the number:");
              double number = double.Parse(Console.ReadLine());
             
             for(double i = 0; i <= number; i++)
             {
              double cubeRoot = Math.Pow( i , (double) 1/3 );
              Console.WriteLine($"The cuberoot of {i} = {Math.Round(cubeRoot , 2)}");

             }
             



             Console.Write("\n\n");
             Console.Write("Display number divisible by 9 and their sum, starting  from 100\n");  
             Console.Write("---------------------------------------------------------------");  
             Console.Write("\n\n");
             Console.Write("Enter minimum number:");
             int minValue = int.Parse(Console.ReadLine()); 
             Console.Write("Enter maxmium number:");
             int maxValue = int.Parse(Console.ReadLine());
              int sum = 0;
             for(int i = minValue; i <= maxValue; i++)
             {
              if(i % 9 == 0)
              {
                Console.WriteLine($"The Value divisible by 9 between {minValue} and {maxValue} is = {i}");
                sum += i;
              }

             }

                Console.WriteLine($"The sum is : {sum}"); 





             /* Console.Write("\n\n");
             Console.Write("Display the square of the number\n");  
             Console.Write("--------------------------------");  
             Console.Write("\n\n"); 
                
             Console.Write("Enter number:");
             int num = int.Parse(Console.ReadLine());
             for(int i = 0; i <= num; i++)
             {
              Console.WriteLine($"The number is {i} and the square of {i} is: {i*i}");
             }



              Console.Write("\n\n");
             Console.Write("Calculate the factorial of a given number\n");  
             Console.Write("-----------------------------------------");  
             Console.Write("\n\n"); 
               int f = 1;
             Console.Write("Input the number:");
             int number = int.Parse(Console.ReadLine());
             for(int i = 1; i <= number; i++)
              f = f*i;
             {
               Console.WriteLine($"The factorial is {number} is: {f}");
             }*/


             int number1 = 14,number2 = 11, result;
             int result2 = number1 | number2;
             Console.WriteLine(result2);




        }
    }
}
