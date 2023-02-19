using System;

namespace Newapp
{
    class Program
    {
        static void Main(string[] args)
        {
            		/*
             * Write an expression that checks whether an integer is odd or even.
             */
            /*Console.WriteLine("-------------------------------Question 1----------------------------------");
            Console.WriteLine("=====\nWrite an expression that checks whether an integer is odd or even.\n=====\n");
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number} is odd? {number % 2 != 0}");
            Console.WriteLine($"The number: {number} is even? {number % 2 == 0}");
            Console.WriteLine();

            /*
             *  Write a Boolean expression that checks whether a given integer is 
             *  divisible by both 5 and 7, without a remainder
             */
            /*Console.WriteLine("-------Question 2-------");
            Console.WriteLine("=====\nWrite a Boolean expression that checks whether a\ngiven integer is divisible by both 5 and 7, without a remainder\n=====\n");
            Console.Write("Enter the number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number2} is divisible by 5 and 7? {(number2 % 5 == 0) && (number2 % 7 == 0)}");
            Console.WriteLine();

            /*
             * Write an expression that calculates the area of a trapezoid by given 
             * sides a, b and height h.
             * 
             * Given that  S = (a + b) * h / 2
             */
            /*Console.WriteLine("-------Question 3-------");
            Console.WriteLine("=====\nWrite an expression that calculates the area of a trapezoid by given sides a, b and height h.\n\nGiven that  S = (a + b) * h / 2\n=====\n");
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            double S = (a + b) * h / 2;

            Console.WriteLine($"The area of the trapezoid of a = {a} b = {b} and h = {h} is: {S}");
            Console.WriteLine();


            /*
             *  The gravitational field of the Moon is approximately 17% of that on the 
             *  Earth. Write a program that calculates the weight of a man on the 
             *  moon by a given weight on the Earth.
             */
            /*Console.WriteLine("-------Question 4-------");
            Console.WriteLine("=====\nThe gravitational field of the Moon is approximately 17% of that on the Earth.\nWrite a program that calculates the weight of a man on the moon by a given weight on the Earth.\n=====\n");
            Console.Write("Enter the weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double percentGiven = 17d / 100;
            Console.WriteLine($"The weight of the man on the moon with {weight} on earth is: {weight * (percentGiven)}");
            Console.WriteLine();


            /*
             * Write a program that takes as input a four-digit number in format abcd
             * (e.g. 2011) and performs the following actions:
             * - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
             * - Prints on the console the number in reversed order: dcba (in our example 1102).
             * - Puts the last digit in the first position: dabc (in our example 1201).
             * - Exchanges the second and the third digits: acbd (in our example 2101).
             */
            /*Console.WriteLine("-------Question 5-------");
            Console.WriteLine("=====\nWrite a program that takes as input a four-digit number in format abcd\n(e.g. 2011) and performs the following actions:\n- Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).\n- Prints on the console the number in reversed order: dcba(in our example 1102).\n- Puts the last digit in the first position: dabc(in our example 1201).\n- Exchanges the second and the third digits: acbd(in our example 2101).\n=====\n");
            Console.Write("Enter a four digit number: ");
            string num = Console.ReadLine();
            int first = Convert.ToInt32(num[0].ToString());
            int second = Convert.ToInt32(num[1].ToString());
            int third = Convert.ToInt32(num[2].ToString());
            int fourth = Convert.ToInt32(num[3].ToString());

            Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
            Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
            Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
            Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");*/


              // Write an expression that checks whether an integer is odd or even.

         Console.WriteLine("----------------- Question 1 ------------------");
         Console.WriteLine($"=====\n Write an expression that checks whether an integer is odd or even.\n=====\n");
         Console.Write("Enter your number: ");
         int number = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"The number is : {number} is odd? {number % 2 != 0}");
         Console.WriteLine($"The number is : {number} is even? {number % 2 == 0}");
         Console.WriteLine();




         //Write a Boolean expression that checks whether a given integer is 
          //divisible by both 5 and 7, without a remainder

         Console.WriteLine("--------Question 2 ----------");
         Console.WriteLine($"=====\n Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder\n=====\n");
         Console.Write("Enter your Number: ");
         int number2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"The number : {number2} is divisible by 5 and 7? {(number2 % 5 == 0 ) || (number % 7 == 0)}");
         Console.WriteLine();




         Console.WriteLine("--------Question 3---------");
         Console.WriteLine("=====\nWrite an expression that calculates the area of a trapezoid by given sides a, b and height h.\nGiven that  S = (a + b) * h / 2\n=====\n");
         
         Console.Write("Enter a : ");
         int a = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter b : ");
         int b = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter h : ");
         int h = Convert.ToInt32(Console.ReadLine());

         double S = (a + b) * h /2;

         Console.WriteLine($"The area of a trapezoid a = {a}, b = {b}, h = {h}, is : {S}");
         Console.WriteLine();



          /*The gravitational field of the Moon is approximately 17% of that on the 
            Earth. Write a program that calculates the weight of a man on the 
              moon by a given weight on the Earth.*/

         Console.WriteLine("-----------Question 4 ------------");
         Console.WriteLine("=====\nThe gravitational field of the Moon is approximately 17% of that on the  Earth.\nWrite a program that calculates the weight of a man on the moon by a given weight on the Earth.\n=====\n");


         Console.WriteLine("Enter the weight :") ;
         double weight = Convert.ToDouble(Console.ReadLine());
         double percentGiven = 17d / 100;
        
         Console.WriteLine($"The weight of a man on the moon is {weight}kg on earth is : {weight * percentGiven}kg ");
         Console.WriteLine();



         Console.WriteLine("----------Question 5 ----------");
         Console.WriteLine("=====\nWrite a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:\n - Calculates the sum of the digits (in our example 2+0+1+1 = 4).\n- Prints on the console the number in reversed order: dcba (in our example 1102).\n-2Puts the last digit in the first position: dabc (in our example 1201).\n- Exchanges the second and the third digits: acbd (in our example 2101)");

         Console.WriteLine("Enter four digits number :");

         string num = Console.ReadLine();
         int first = Convert.ToInt32(num[0].ToString());
         int second = Convert.ToInt32(num[1].ToString());
         int third = Convert.ToInt32(num[2].ToString());
         int fourth = Convert.ToInt32(num[3].ToString());


         Console.WriteLine($"Calculates the sum of the four digits: {first + second + third + fourth}");
         Console.WriteLine($"Prints on the console the number in reversed order : {fourth}{third}{second}{first}");
         Console.WriteLine($"Puts the last digit in the first position : {fourth}{first}{second}{third}");
         Console.WriteLine($"Exchanges the second and third digits : {first}{third}{second}{fourth}");
         Console.WriteLine();



         Console.WriteLine("This program helps you calculate the volume of a cylinder");

         Console.Write("Enter your radius:");
         double radius = Convert.ToDouble(Console.ReadLine());

          Console.Write("Enter your length:");
         double length = Convert.ToDouble(Console.ReadLine());

         double area = radius * radius * Math.PI;

         double volume = area * length;

         Console.WriteLine($"The value of the area is {area}cm^2 and the value of the volume is {volume}cm^3");
         Console.WriteLine();

         Console.WriteLine("Simple Bank Transfer System");
         int realUserId = 1234;

         Console.Write("Enter your starting balance:");
         double startingBalance = double.Parse(Console.ReadLine());
         Console.WriteLine("Enter your account number");
         long validAccountNumber = int.Parse(Console.ReadLine());

         Console.Write("Enter Your user ID:");
         int userId = Convert.ToInt32(Console.ReadLine());

         Console.Write("Enter the number of transfers you would like to make:");
         int numberOfTransfer = Convert.ToInt32(Console.ReadLine());

         if (userId != realUserId)
         {
             Console.Write("Unknown User ID!");
         }
        else if(userId == realUserId)
         {
            
            decimal amountToTransfer = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter receipent bank account number:");
            long receipentAccountNum = long.Parse(Console.ReadLine());
            
             string [] bankName =  {"Zenith", "Gtbank" , "Firstbank" };
              Console.WriteLine($"Do you want to transfer {amountToTransfer} to {receipentAccountNum}\n{bankName[1]}");
              Console.ReadLine();


            
         }
        

          

        
         

         

         

























        }
    }
}
