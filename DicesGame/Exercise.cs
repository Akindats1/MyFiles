using System.Runtime.InteropServices;
using System.Collections.Concurrent;
using System.Reflection.Emit;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DicesGame
{
    public static class Exercise
    {
       public static void DiceGame()
       {
         Console.WriteLine("Press any key to start your game");
         Console.ReadKey();
         Random random = new Random();
         int firstDie = 6;
         int secondDie = 5;
         int thirdDie = 2;
         string message =$"{firstDie},{secondDie},{thirdDie} ";
         int total = firstDie + secondDie + thirdDie;

         if ((firstDie == secondDie) && (secondDie == thirdDie))
         {
            total += 6;
            Console.WriteLine($"You rolled {message}\nAdding bonus to your point for a triple (+6), your total point is {total}");
         }
         else if(firstDie == secondDie || secondDie == thirdDie || firstDie == thirdDie)
         {
            total += 2;
            Console.WriteLine($"You rolled \n{message}\nAdding bonus to your point for a double +2, your total point is {total} ");
         }
         else
         {
            Console.WriteLine($"You rolled {message}\nTotal point is:{total}");
         }
         
         
         if(total <  11)
         {
            Console.WriteLine("Try Again!");
         }
         else if( total <= 14)
         {
            Console.WriteLine("You won yourself wristwatch ");
         }
         else if(total == 15 || total <=18)
         {
            Console.WriteLine("You won yourself a wristwatch");
         }
         else
         {
            Console.WriteLine("You won yourself a laptop");
         }
       }

       public static void LoginChecker()
       {
         string userName = "Akindats";
         string passWord = "sskkdt";

         Console.WriteLine("Enter your username: ");
         string myUsername = Console.ReadLine();
         Console.WriteLine("Enter your password: ");
         string myPassword = Console.ReadLine();
         int attempts = 3;

         while(!(attempts < 1))
         {
            if(myUsername != userName || myPassword != passWord)
            {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine($"Sorry,Incorrect username or password!\n You have {attempts--} attempts left!");
               Console.ForegroundColor = ConsoleColor.Cyan;
               Console.WriteLine("Enter your username again: ");
               Console.ForegroundColor = ConsoleColor.Yellow;
               myUsername = Console.ReadLine();
               

               Console.ForegroundColor = ConsoleColor.Cyan;  
               Console.WriteLine("Enter your password again: ");
               Console.ForegroundColor = ConsoleColor.Yellow;
               myPassword = Console.ReadLine();
               Console.Clear();

               if (attempts == 0)
               {
                  Console.BackgroundColor = ConsoleColor.Red;
                  Console.WriteLine("You have been locked out of the system, please try again");
                  break;
               }
                     
            }


            else if(myUsername == userName && myPassword == passWord)
            {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine($"Welcome {userName}!");
               break;
            }
         }
       }

       public static string ReverseString()
       {
         Console.WriteLine("Enter your word: ");
         string originalString = Console.ReadLine();
         string reverseString = " ";
         for(int i = originalString.Length - 1; i >= 0; i--)
         {
            reverseString += originalString[i];
         }
         return reverseString;
      }

      public static string ReverseStringUsingRecursion(string word)
      {
         if((word == " ") || (word.Length <= 1))
         {
            return word;

         }
        
         return ReverseStringUsingRecursion(word.Substring(1)) + word[0];
      }

      public static string RecursionSort(string words)
      {
         if(words.Length > 0)
         {
            return words[words.Length - 1] + RecursionSort(words.Substring(0 , words.Length - 1));
         }
         return words;
      }
      
       
    }
} 