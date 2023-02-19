using System;
using System.IO;

namespace SolveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filepath = @"Files\employees.txt";

            if(File.Exists(filepath))
            {
                using(File.Create(filepath))
                {

                }
            }
            else
            {
                string writeText = "Hello world";
                File.WriteAllText(filepath, writeText);

                string readText = File.ReadAllText(filepath);
                Console.WriteLine(readText);
            }
            
            
      	//    //Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, 
        //    //such that the remainder of their division by 5 is 0.
        //    //Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25. 
           
           
        //     Console.Write("\n\n");
        //     Console.Write("Question 1\n");
        //     Console.Write("----------");
        //     Console.Write("\n\n");
        
            

            
        //     Console.WriteLine("Enter first number:");
        //     int firstInput = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter second number:");
        //     int secondInput = int.Parse(Console.ReadLine());
        //     for(int i = firstInput; i <= secondInput; i++)
        //     {
        //         if(i % 5 == 0)
        //         {
        //             Console.WriteLine($"The numbers that exist between them that is divisible by 5: {i}");
        //         }
        //     }

        //     	//Write a program that prints on the console the first 100 numbers in the
        //         //Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … 

             
        //     Console.Write("\n\n");
        //     Console.Write("Question 2\n");
        //     Console.Write("----------\n");
        //     Console.Write("Display first 100 numbers in the fibonacci sequence\n");
        //     Console.Write("---------------------------------------------------");
        //     Console.Write("\n\n");

        //     uint firstNumber = 0, secondNumber = 1, nextNumber,number = 100;
            

        //     Console.Write($"{firstNumber + " " + secondNumber},");
        //     for(uint i = 0; i <= number; i++)
        //     {
               
        //         nextNumber = firstNumber + secondNumber;
        //         Console.Write($" {nextNumber}," );
        //         firstNumber = secondNumber;
        //         secondNumber = nextNumber;
                
        //     }

        //     // //	Write a program that finds the greatest of given 5 numbers.
            
        //     // Console.Write("\n\n");
        //     // Console.Write("Question 3\n");
        //     // Console.Write("----------\n");
        //     // Console.Write("This program finds the greatest of given 5 numbers\n");
        //     //  Console.Write("-------------------------------------------------");
        //     // Console.Write("\n\n");
        //     // Console.Write("Enter first Number:");
        //     // decimal num1= decimal.Parse(Console.ReadLine());
        //     // Console.Write("Enter second Number:");
        //     // decimal num2 = decimal.Parse(Console.ReadLine());
        //     // Console.Write("Enter third Number:");
        //     // decimal num3 = decimal.Parse(Console.ReadLine());
        //     // Console.Write("Enter fourth Number:");
        //     // decimal num4 = decimal.Parse(Console.ReadLine());
        //     // Console.Write("Enter fifth Number:");
        //     // decimal num5 = decimal.Parse(Console.ReadLine());

        //     // if((num1>=num2) && (num1>=num3) && (num1>=num4) && (num1>=num5))
        //     // {
        //     //     Console.WriteLine($"The greatest number is: {num1}");
        //     // }
        //     // else if((num2>=num1) && (num2>=num3) && (num2>=num4) && (num2>=num5))
        //     // {
        //     //     Console.WriteLine($"The greatest number is: {num2}");
        //     // }
        //     // else if((num3>=num1) && (num3>=num2) && (num3>=num4) && (num3>=num5))
        //     // {
        //     //     Console.WriteLine($"The greatest number is: {num3}");
        //     // }
            // else if((num4>=num1) && (num4>=num2) && (num4>=num3) && (num4>=num5))
            // {
            //     Console.WriteLine($"The greatest number is: {num4}");
            // }
            // else if((num5>=num1) && (num5>=num2) && (num5>=num3) && (num5>=num4))
            // {
            //     Console.WriteLine($"The greatest number is: {num5}");
            // }

            // 	/*Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c,
            //     calculates and prints its real roots (if they exist).
            //     Quadratic equations may have 0, 1 or 2 real roots. Hints: From math it is known,
            //     that a quadratic equation may have one or two real roots or no real roots at all.
            //     In order to calculate the real roots of a given quadratic equation,
            //     we first calculate the discriminant (D) by the formula: D = b2 - 4ac.
            //     If the discriminant is zero, then the quadratic equation has one double real root and
            //     it is calculated by the formula: x = -b/2a. 
            //     If the value of the discriminant is positive, 
            //     then the equation has two distinct real roots, 
            //     which are calculated by the formula: x=(-b±√(b^2-4ac))/2a .
            //     If the discriminant is negative, the quadratic equation has no real roots.*/

                
            // Console.Write("\n\n");
            // Console.Write("Question 4\n");
            // Console.Write("----------\n");
            // Console.Write("This program prints real root(s) of quadratic equation (if they exist)\n");
            // Console.Write("----------------------------------------------------------------------");
            // Console.Write("\n\n");

            // Console.WriteLine("Enter the value of a:");
            // double a = double.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the value of b:");
            // double b = double.Parse(Console.ReadLine());
            // Console.WriteLine("Enter the value of c:");
            // double c = double.Parse(Console.ReadLine());

            // double D = b * b - 4 * a * c;

            // if(D < 0)
            // {
            //     Console.WriteLine($"There are no real roots:{D}");
            // }
            // else if(D == 0)
            // {
               
            //    double x = (-b /(2 * a));
            //    Console.WriteLine($"There is one real root: {x}");
            // }
            // else
            // {
            //     double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            //     double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            //     Console.WriteLine($"There are two real roots:{x1} and {x2}");
            // }

            // /* Write a program that applies bonus points to given scores in the range [1…9] by the following rules: 
            //   •	If the score is between 1 and 3, the program multiplies it by 10.
            //   •	If the score is between 4 and 6, the program multiplies it by 100. 
            //   •	 If the score is between 7 and 9, the program multiplies it by 1000.
            //   •	 If the score is 0 or more than 9, the program prints an error message. Hints – Use Switch Statements.*/
              
                  
            // Console.Write("\n\n");
            // Console.Write("Question 5\n");
            // Console.Write("----------\n");
            // Console.Write("This program applies bonus point to given scores from (1...9)\n");
            // Console.Write("-------------------------------------------------------------");
            // Console.Write("\n\n");
            // Console.WriteLine("Enter the score between 1-9:");
            // int numberInput = int.Parse(Console.ReadLine());
            // switch(numberInput)
            // {
            // case 1:
            // case 2:
            // case 3:
            //     Console.WriteLine($"The bonus score is: {numberInput * 10}");
            //     break;
            // case 4:
            // case 5:
            // case 6:
            //     Console.WriteLine($"The bonus score is: {numberInput * 100}");
            //     break;
            // case 7:
            // case 8:
            // case 9:
            //     Console.WriteLine($"The bonus score is: {numberInput * 1000}");
            //     break;
            // default:
            //     Console.WriteLine("Invalid input!");
            //     break;


            // }


            //     /*	Write a program that prints on the console the numbers from 1 to N,
            //     which are not divisible by 3 and 7 simultaneously.
            //     The number N should be read from the standard input.
            //     Hints (Use a for-loop and the operator % for finding the remainder in integer division.
            //     A number num is not divisible by 3 and 7 simultaneously exactly when (num % (3*7) == 0))*/

                       
            //  Console.Write("\n\n");
            //  Console.Write("Question 6\n");
            //  Console.Write("----------\n");
            //  Console.Write("Numbers which are not divisile by 3 and 7 simultaneously\n");
            //  Console.Write("--------------------------------------------------------");
            //  Console.Write("\n\n");
            //     Console.WriteLine("Enter number:");
            //     int numberlength= int.Parse(Console.ReadLine());
            //     for(int i = 1;  i <= numberlength; i++)
            //     {
            //         if(i % (3 * 7) != 0)
            //         {
            //             Console.WriteLine(i);
            //         }
            //     }

            // 	 /*Write a program that prints all possible cards from a standard deck of cards, without jokers
            //      (there are 52 cards: 4 suits of 13 cards). 
            //      Hints (Number the cards from 2 to 14
            //     (these numbers will match the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A). 
            //      Number the suits from 1 to 4 (1 – club, 2 – diamond, 3 – heart and 4 – spades).
            //      Now you can use the two nested loops and print each of the cards with two switch statements)*/

                        
            //      Console.Write("\n\n");
            //      Console.Write("Question 7\n");
            //      Console.Write("----------");
            //      Console.Write("Program prints all possible cards from a standard deck of cards\n");
            //      Console.Write("---------------------------------------------------------------");
            //      Console.Write("\n\n");
            //      for(int i = 1; i <= 4; i++)
            //      {
            //         for(int j = 2; j <= 14; j++)
            //         {
            //             switch(i)
            //      {
            //         case 1:
            //             Console.WriteLine("Club");
            //             break;
            //         case 2:
            //             Console.WriteLine("Diamond");
            //             break;
            //         case 3:
            //             Console.WriteLine("Heart");
            //             break;
            //         case 4:
            //             Console.WriteLine("Spades");
            //             break;
            //         }




            //        switch(j)
            //      {
            //         case 2:
            //             Console.WriteLine("2");
            //             break;
            //         case 3:
            //             Console.WriteLine("3");
            //             break;
            //         case 4:
            //             Console.WriteLine("4");
            //             break;
            //         case 5:
            //             Console.WriteLine("5");
            //             break;
            //         case 6:
            //             Console.WriteLine("6");
            //             break;
            //         case 7:
            //             Console.WriteLine("7");
            //             break;
            //         case 8:
            //             Console.WriteLine("8");
            //             break;
            //         case 9:
            //             Console.WriteLine("9");
            //             break;
            //         case 10:
            //             Console.WriteLine("10");
            //             break;
            //         case 11:
            //             Console.WriteLine("J");
            //             break;
            //         case 12:
            //             Console.WriteLine("K");
            //             break;
            //         case 13:
            //             Console.WriteLine("Q");
            //             break;
            //         case 14:
            //             Console.WriteLine("A");
            //             break;       
            //      }
                 
            //      }
                 
            //      }
            //       /*Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence:
            //       0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … 
            //       Hints (Fibonacci numbers start from 0 and 1, each additional is obtained as the sum of the previous two.
            //       You can find the first n Fibonacci numbers with a for-loop from 1 to n,
            //       and at each iteration calculate the next number by using the previous two 
            //       (which you will keep in two additional variables)).*/

            //        Console.Write("\n\n");
            //        Console.Write("Question 8\n");
            //        Console.Write("----------\n");
            //        Console.Write("Display numbers in the fibonacci sequence\n");
            //        Console.Write("-----------------------------------------");
            //        Console.Write("\n\n");

            //       ulong firstNum = 0, secondNum = 1, nextNum,sum;
            
            //        Console.WriteLine("Enter number:");
            //         sum = ulong.Parse(Console.ReadLine());
            //        Console.Write($"{firstNum + " " + secondNum},");
            //        for(ulong i = 2; i <= sum; i++)
            //      {
               
            //          nextNum = firstNum + secondNum;
            //          Console.Write($" {nextNum}," );
            //          firstNum = secondNum;
            //          secondNum = nextNum;
            //      }

            //      /*Write a program that for a given number n, outputs a matrix in the form of a spiral: 
            //                                     Example for n=4 
            //                                     1	2	3	4
            //                                     12	13	14	5
            //                                     11	16	15	6
            //                                     10	9	8	7*/


            //      Console.Write("\n\n");
            //      Console.Write("Question 9\n");
            //      Console.Write("----------");
            //      Console.Write("\n\n");
                 
            //      int[,] matrix =
            //                 {
            //                 {1, 2, 3, 4},
            //                 {12, 13, 14, 5},
            //                 {11, 16, 15, 6},
            //                 {10, 9, 8, 7},
            //                 };
            //                 // Print the matrix on the console
            //                 for (int row = 0; row < matrix.GetLength(0); row++)
            //                 {
            //                 for (int col = 0; col < matrix.GetLength(1); col++)
            //                 {
            //                 Console.Write(matrix[row   ,  col]  + "\t");
            //                 }
            //                 Console.WriteLine("\n");
            //                 }


            //      	/*Write a program, which creates an array of 20 elements of type integer
            //         and initializes each of the elements with a value equals to the index of the element multiplied by 5.
            //         Print the elements to the console.*/

            //      Console.Write("\n\n");
            //      Console.Write("Question 10\n");
            //      Console.Write("-----------");
            //      Console.Write("\n\n");

            //      int[] array = new int[20];

            //      for(int i = 0; i < array.Length; i++)
            //      {
            //         array[i] = i * 5;
            //         Console.WriteLine(array[i]);
            //      }
            //      /*Write a program, which reads two arrays from the console and checks whether they are equal 
            //      (two arrays are equal when they are of equal length and all of their elements, 
            //      which have the same index, are equal).*/
            //      Console.Write("\n\n");
            //      Console.Write("Question 11\n");
            //      Console.Write("-----------");
            //      Console.Write("\n\n");
            //      bool arraysEqual = true;
            //      Console.Write("Enter the length of the first array:\n");
            //      int firstLength = int.Parse(Console.ReadLine());
            //      int[] firstArray = new int [firstLength];

            //      for(int i = 0; i < firstArray.Length; i++)
            //      {
            //         Console.Write($"Enter element {i} :");
            //         firstArray[i] = int.Parse(Console.ReadLine());
                    
            //      }

               
                      
            //      Console.Write("Enter the length of the second array:\n");
                 
            //      if(firstLength != int.Parse(Console.ReadLine()))
            //      {
            //         Console.WriteLine("The arrays are not of the same length therefore arrays are not equal");
            //      }
            //      else
            //      {
            //         int[] secondArray = new int [firstLength];
                    
            //         for(int i = 0; i < secondArray.Length; i++)
            //      {
            //         Console.Write($"Enter element {i}: ");
            //         secondArray[i] = int.Parse(Console.ReadLine());
            //      }
                 
            //      for(int i = 0; i < firstArray.Length; i++)
            //      {
            //         if(firstArray[i] != secondArray[i])
            //         {
            //             Console.WriteLine("The element in the arrays are different therefore arrays are not equal");
            //             arraysEqual = false;
            //             break;
            //         }
                   
            //      }

                   
            //      if(arraysEqual)
            //      {
            //         Console.WriteLine("The arrays are equal");
            //      }
                 
            //      }

            //       // Write a program, which finds the maximal sequence of consecutive equal elements in an array.
            //         //E.g.: {1, 1, 2, 3, 2, 2, 2, 1} :{2, 2, 2}
                 
            //       /*Console.Write("\n\n");
            //       Console.Write("Question 12\n");
            //       Console.Write("-----------\n");
            //       Console.Write("This program finds the maximal sequence of consecutive equal elements in an array\n");
            //       Console.Write("---------------------------------------------------------------------------------");
            //       Console.Write("\n\n");

            // int count = 1, tempCount = 1, number = 0;

			// Console.Write ("Enter array length: ");
			// int length = int.Parse (Console.ReadLine ());
			// int[] arr = new int[length];

			// for (int i = 0; i < arr.Length; i++) 
			// {
			// 	Console.Write ($"Enter element {i}:");
			// 	arr[i] = int.Parse (Console.ReadLine ());
			// }

			// for (int i = 0; i < arr.Length - 1; i++) 
			// {
            //   if(arr[i] == arr[i + 1])
            //   {
            //     tempCount++; 
            //   }
            //   else
            //   {
            //     tempCount = 1;
            //   }
                

			// 	if (tempCount > count) 
			// 	{
			// 		count = tempCount;
			// 		number = arr[i];
			// 	}
			// }

			// for (int i = 0; i < count; i++)
            // {
            //     Console.Write ($"{number},");
            // }/*



            //      	 //Write a program, which finds the most frequently occurring element in an array.
            //          //Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} 4 (5 times). 
                     
            //      Console.Write("\n\n");
            //      Console.Write("Question 13\n");
            //      Console.Write("-----------\n");
            //      Console.Write("This program finds the most frequently occurig elementin an array\n");
            //      Console.Write("-----------------------------------------------------------------");
            //      Console.Write("\n\n");

                 
            // int counts = 0, tempCounter = 1, numberFound = 0;

			// Console.Write ("Enter array length: ");
			// int arrLength = int.Parse (Console.ReadLine ());
			// int[] array2 = new int[arrLength];

			// for (int i = 0; i < arrLength; i++) 
			// {
			// 	Console.Write ($"Enter element {i}:");
			// 	array[i] = int.Parse (Console.ReadLine ());
			// }

			// for (int i = 0; i < arrLength - 1; i++) 
			// {
            //   if(array[i] == array[i + 1])
            //   {
            //     tempCounter++; 
            //   }
            //   else
            //   {
            //     tempCounter = 1;
            //   }
                

			// 	if (tempCounter > counts) 
			// 	{
			// 		counts = tempCounter;
			// 		numberFound = array[i];
			// 	}
			// }

			// for (int i = 0; i < counts; i++)
            // {
            //     Console.Write ($"{numberFound} was found {counts} times");
            //     break;
            // }





            //       //Write a program that converts a decimal number to binary one. 

            //      Console.Write("\n\n");
            //      Console.Write("Question 14\n");
            //      Console.Write("-----------\n");
            //      Console.Write("Converts a decimal number to binary one\n");
            //      Console.Write("---------------------------------------");
            //      Console.Write("\n\n");

            //      Console.Write("Enter decimal number:");
            //      int decimalNumber = int.Parse(Console.ReadLine());
            //      string binaryNumber = Convert.ToString(decimalNumber , 2);
            //      Console.WriteLine($"Binary value: {binaryNumber}");




            //       // Write a program that converts a binary number to decimal one. 

            //      Console.Write("\n\n");
            //      Console.Write("Question 15\n");
            //      Console.Write("-----------\n");
            //      Console.Write("Converts a binary number to decimal one\n");
            //      Console.Write("---------------------------------------");
            //      Console.Write("\n\n");

            //      Console.Write("Enter binary number: ");
            //      int binaryValue = int.Parse(Console.ReadLine());
            //      int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);           
            //      Console.Write($"Decimal Value : {decimalValue} ");

            //      // Write a program that converts a decimal number to hexadecimal one.
            //       Console.Write("\n\n");
            //       Console.Write("Question 16\n");
            //       Console.Write("-----------\n");
            //     Console.Write("Converts a decimal number to hexadecimal one\n");
            //      Console.Write("-------------------------------------------");
            //       Console.Write("\n\n");

            //       Console.Write("Enter decimal number: ");
            //      int decimalNum = int.Parse(Console.ReadLine());
            //      string hexaDecimalValue = (decimalNum.ToString("x"));           
            //      Console.Write($"Hexadecimal Value : {hexaDecimalValue} ");

            //      //	Write a program that converts a hexadecimal number to decimal one. 
            //       Console.Write("\n\n");
            //       Console.Write("Question 17\n");
            //       Console.Write("-----------\n");
            //       Console.Write("Converts a hexadecimal number to decimal one\n");
            //      Console.Write("---------------------------------------------");
            //       Console.Write("\n\n");

                  
            //      Console.Write("Enter hexadecimal number: ");
            //      string hexaDecimalNum = Console.ReadLine();
            //      Console.WriteLine($"Decimal Value : {Convert.ToInt32(hexaDecimalNum , 16)} ");

            //      //	Write a program that converts a hexadecimal number to binary one. 
            //       Console.Write("\n\n");
            //       Console.Write("Question 18\n");
            //       Console.Write("-----------\n");
            //       Console.Write("Converts a hexadecimal number to binary one\n");
            //      Console.Write("-------------------------------------------");
            //       Console.Write("\n\n");

            //      Console.Write("Enter hexadecimal number: ");
            //      string hexaDecimalNumber = Console.ReadLine();
            //      Console.WriteLine($"Binary Value : {Convert.ToString(Convert.ToInt32(hexaDecimalNum , 16) , 2)} ");

            //      //	 Write a program that converts a binary number to hexadecimal one. 
            //       Console.Write("\n\n");
            //       Console.Write("Question 19\n");
            //       Console.Write("-----------\n");
            //       Console.Write("Converts a binary number to hexadecimal one\n");
            //      Console.Write("---------------------------------------");
            //       Console.Write("\n\n");

            //       Console.Write("Enter binary number: ");
            //      string binary = Console.ReadLine();
            //      Console.WriteLine($"Hexadecimal Value : {Convert.ToInt32(binary , 2).ToString("x")}");

            //      	/*Write a program, which creates square matrices like those in the figures below
            //          and prints them formatted to the console.
            //          The size of the matrices will be read from the console.
            //           See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion: 
            //                                 A.	
            //                                 1	5	9	13
            //                                 2	6	10	14
            //                                 3	7	11	15
            //                                 4	8	12	16

            //                                 B.	
            //                                 1	8	9	16
            //                                 2	7	10	15
            //                                 3	6	11	14
            //                                 4	5	12	13

            //                                 C.	

            //                                 7	11	14	16
            //                                 4	8	12	15
            //                                 2	5	9	13
            //                                 1	3	6	10*/
            //       Console.Write("\n\n");
            //       Console.Write("Question 20\n");
            //       Console.Write("-----------");
            //       Console.Write("\n\n");


            //      Console.Write("Enter the number of the rows: ");
            //      int rows = int.Parse(Console.ReadLine());
            //      Console.Write("Enter the number of the columns: ");
            //      int cols = int.Parse(Console.ReadLine());
            //      int[,] matrixNumber = new int[rows, cols];
            //      Console.WriteLine("Enter the cells of the matrix:");
            //      for (int row = 0; row < rows; row++)
            //      {
            //      for (int col = 0; col < cols; col++)
            //      {
            //      Console.Write($"matrixNumber[{row},{col}] = ");
            //      matrixNumber[row, col] = int.Parse(Console.ReadLine());
            //      }
            //      }
            //      for (int row = 0; row < matrixNumber.GetLength(0); row++)
            //      {
            //      for (int col = 0; col < matrixNumber.GetLength(1); col++)
            //      {
            //      Console.Write(" " + matrixNumber[row, col]);
            //      }
            //      Console.WriteLine();
            //      }

                 
 



                 











    



            

               

                 


                



                

                 	





                 
               
           

            




                       

            
            
    

 






        }
    }
}
