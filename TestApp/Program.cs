using System;


namespace TestApp

{ class Program
    {
        static void Main(string[] args)
        { 
            

             /*Console. WriteLine ("Enter firstname:" );


             string firstName = Console.ReadLine ();
            
             Console. WriteLine ("Enter lastname:");

             string lastName = Console.ReadLine ();
             
             Console. WriteLine ("Enter Age:");

             double age = Convert.ToInt16(Console.ReadLine ());

             Console. WriteLine ("Enter favorite color:");

             string favoriteColor = Console.ReadLine ();

             Console. WriteLine ("Enter favorite food:");

             string favoriteFood = Console.ReadLine ();

             Console. WriteLine ("Enter state of origin:");

             string stateOfOrigin = Console.ReadLine ();

             string result1 = ($"My name is {firstName} {lastName} from {stateOfOrigin}.\nI am  {age} years old.\nMy favorite food is {favoriteFood} and my favorite color is {favoriteColor}.");

             Console.WriteLine(result1);

             Console.WriteLine($"Thanks for your details {firstName} {lastName}");

             Console.WriteLine("Thanks for your \"feedback\"");
             Console.WriteLine();*/


            /* Console.WriteLine("Enter Your Account Number: ");
             double accountNumber = Convert.ToInt32(Console.ReadLine()); 
             Console.WriteLine("Enter Your Bank name: ");
             string bankName = Console.ReadLine ();
             Console.WriteLine("Enter Your transfer amount: ");
             double transferAmount = Convert.ToInt32(Console.ReadLine());

             if (transferAmount < 0)  
             {
                Console.WriteLine("Transfer sucessful");
             }
             else if (accountNumber == 0)
             {
                Console.WriteLine("Invalid account Number");
             }
             else
             {
                Console.WriteLine("Valid account");
             }*/

             /* double radius = (150 - 142 )/ 3;
             double areaOfCirle = Math.PI * radius * radius;
             double perimeter = 2 * Math.PI * radius;
             Console.WriteLine(areaOfCirle);
             Console.WriteLine(perimeter);*/

             // double x = 12;
             // x--;
              //Console.WriteLine((x > 3 && x <= 12));

              /*double num1 = 0;
              double num2 = 0;
              //Display title as the Console C# calculator
              Console.WriteLine("\tConsole Calculator in C#");
              Console.WriteLine("\t----------------------------");

             //Ask user to input the first number
             Console.WriteLine("Input first operand number:");
             num1 = double.Parse(Console.ReadLine());

            // Ask user to choose an option.
             Console.WriteLine("Choose an operator: ");
             Console.WriteLine("\t\t\t+ - Add ");
             Console.WriteLine("\t\t\t- - Subtract  ");
             Console.WriteLine("\t\t\t* - Multiply ");
             Console.WriteLine("\t\t\t/ - Divide ");
             Console.WriteLine("\t\t\t% - Remainder ");
             Console.WriteLine("Your Option: ");
             string action = Console.ReadLine();

            // //Ask user to input the second number 
             Console.WriteLine("Input second operand number:");
             num2 = double.Parse(Console.ReadLine());

            
            
 
            // //Use a switch statement to do the math
              switch (action.ToLower())
              {
                 case "+":
                 case "add":
                   Console.WriteLine($"Your result : {num1} + {num2} = {num1 + num2}");
                   break;
                
                 case "-":
                 case "subtract":
                 Console.WriteLine($"Your result : {num1} - {num2} = {num1 - num2}");
                   break;
                
                  case "*":
                  case "multiply":
                   Console.WriteLine($"Your result : {num1} * {num2} = {num1 * num2}");
                  break;
                
                 case "/":
                 case "divide":
                   Console.WriteLine($"Your result : {num1} / {num2} = {num1 / num2}");
                   break;

                  case "%":
                  case "remainder":
                  Console.WriteLine($"Your result : {num1} % {num2} = {num1 % num2}");
                   break;

                 default:
                   Console.WriteLine("Invalid input!");
                   break;
             }
             //Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app....");
            Console.ReadKey();*/


          // Question 1
          /*Console.WriteLine("------------- Question 1 -----------");
          Console.WriteLine("Enter your first word :");
          string firstWord = Console.ReadLine();
          double firstWordLength = firstWord.Length;
          Console.WriteLine("Enter your second word :");
          string secondWord = Console.ReadLine();
          double secondWordLength = secondWord.Length;
          double bothWordLength = firstWordLength + secondWordLength;
          double result = (bothWordLength > 20) ? bothWordLength * 3 : bothWordLength + 20;
          Console.WriteLine(result);
          Console.WriteLine();


           Console.WriteLine("----------Question 2-----------------");
           decimal costPrice = 200.876m;
           decimal sellingPrice = 255.425m;
           decimal profit = sellingPrice - costPrice;
           Console.WriteLine($"The Selling price - the cost price is : ${profit}");
           Console.WriteLine($"The profit is ${Math.Round(profit , 2)}");
           Console.WriteLine();


           
           Console.WriteLine("----------Question 3-----------------");
           string word = Console.ReadLine();
           double index = word.IndexOf( word[2]);
           double wordLength = word.Length;
           double newLength = index + wordLength;
           char newResult = (char)newLength;

           Console.WriteLine($"The third character in {word} is : {word[2]}");
           Console.WriteLine($"The length of the {word} is : {wordLength}");
           Console.WriteLine($"The index of the third character is {index}\nThe value added to the string is {wordLength} and the addition is {newLength} and the conversion to character is {newResult}");
           Console.WriteLine();

            Console.WriteLine("----------Question 4-----------------");
            Console.Write("Input your first number:");
            double firstInput = double.Parse(Console.ReadLine());
            Console.Write("Input your second number:");
            double secondInput = double.Parse(Console.ReadLine());
            double greaterNumber = Math.Max(firstInput , secondInput);
            Console.WriteLine($"The greater number is : {greaterNumber}");


            Console.WriteLine("----------Question 5-----------------");
            double sum = 0;
            double i = 0;

            while (i <= 4)
            {
                Console.Write("Please enter an integer:");
                string input = Console.ReadLine();
                double x;
                bool isInteger = double.TryParse(input , out x);

                if (!isInteger)
                {
                    i--;
                    Console.Write("Invalid input! ");
                }
                sum += x;
                i++;
            }
            
            Console.WriteLine($"The sum of the integers are: {sum} ");
            Console.WriteLine();

            
            Console.WriteLine("----------Question 6-----------------");
            const double constantValue = 5;
            Console.Write("Enter first number");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("Enter second number");
            double numberTwo = double.Parse(Console.ReadLine());
            double solution = numberOne + numberTwo - constantValue;
            Console.WriteLine("Enter the correct answer:");
            double correctAnswer = double.Parse(Console.ReadLine());

            string printResult = (correctAnswer == solution) ? "Correct Answer!" : $"Wrong Answer! The correct answer is {solution}";
            Console.WriteLine(printResult);
            Console.WriteLine();

             Console.WriteLine("----------Question 7-----------------");
              Console.WriteLine("Enter a number:");
           double number = double.Parse(Console.ReadLine());
           switch (number)
          {
            case 0:
            Console.WriteLine("Zero");
            break;
            case 1:
            Console.WriteLine("One");
            break;
            case 2:
            Console.WriteLine("Two");
            break;
            case 3:
            Console.WriteLine("Three");
            break;
            case 4:
            Console.WriteLine("Four");
            break;
            case 5:
            Console.WriteLine("Five");
            break;
            case 6:
            Console.WriteLine("Six");
            break;
            case 7:
            Console.WriteLine("Seven");
            break;
            case 8:
            Console.WriteLine("Eight");
            break;
            case 9:
            Console.WriteLine("Nine");
            break;
            default:
            Console.WriteLine("Invalid input!");
            break;*/ 
          
          /*double num1;
          double num2;
          double num3;
         
         Console.WriteLine("Input first operand number:");
         num1 = double.Parse(Console.ReadLine());
         Console.WriteLine("Input second operand number:");
         num2= double.Parse(Console.ReadLine());
         num3 =  num1 + num2;

         
         if(num1 + num2 == num3)
         {
            Console.WriteLine($"The result is {num1} + {num2} = {num1 + num2}");
         }*/


        Helper.MultiplicationTable();
       








        }

      }   
  }
    

    

    