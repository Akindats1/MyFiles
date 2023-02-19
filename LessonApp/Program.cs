using System;

namespace LessonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int[,] matrix =
            // {
            // {1, 2, 3, 4}, 
            // {5, 6, 7, 8},
            // {12, 3, 45, 4},             
            // };
            // foreach (int m in matrix)
            // {
            //     Console.Write(m);
            // };

            

            // Console.WriteLine("Enter length of array:");
            // int n = int.Parse(Console.ReadLine());
            // int[] array = new int [n];
            // foreach (int a in array)
            // {
            //     Console.WriteLine(a);
            // }

            // int[] myArray = new int[6] {4,5,9,6,8,7,7};
            // foreach (int t in myArray)
            // {
            //     Console.WriteLine(t);
            // }

            
             Console.WriteLine("Enter a positive value: ");
             try
             {
                int n = int.Parse(Console.ReadLine()); 
                Console.Clear(); 
                FizzBuzz(n);

             }
             catch (Exception ex)
             {
                
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);

             }
             finally
             {
                Console.WriteLine("The value you enter must be positive!");
             }
            
            
        }

        static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if(i % 5 == 0)
                {
                   Console.WriteLine("Buzz"); 
                   continue; 
                }
            
                Console.WriteLine(i);



             string[] mgqsStudentsMale = {"Intisor Abdul Awwal", "Abdulsalam Sultan", "AbdulWarith Ismail", "Oni Bashir Muhammad Bashir","Abdul Waheed Mahmood","Adelakun AbdulLateef","AbdulTawwab Tolani","Elias Bashirudeen","Akintola AbdulHaseeb","Oluwa Muhammad","Haruna AbdulMalik" };

             string[] mgqsStudentsFemale = {"Jubreel farhanas","Oyekola Hafsah-Qanitah","Timehin Hameedah","Bamgbose Balkis Alabi","Hamzah Fawazah","Abdussalam Ameerah","Aisha Adeoye"};
           

               
            
             string[] kitchen = {mgqsStudentsFemale[0],mgqsStudentsFemale[1],mgqsStudentsFemale[2],mgqsStudentsFemale[4],mgqsStudentsFemale[6]};

               Console.WriteLine("Kitchen and washing plates.");
               for(int i = 0; i < kitchen.Length;i++)
               {
                   
                    Console.WriteLine(kitchen[i]);
               }

               string[] dining = {mgqsStudentsFemale[5],mgqsStudentsMale[8]};

               Console.WriteLine("Dining corridor.");
               for(int j = 0; j < dining.Length;j++)
               {
                    
                    Console.WriteLine(dining[j]);
               }
            }



               
                
                 
        }


       
    

        static double AreaOfACircle(double radius)
        {
            double area;
            const double PI = Math.PI;
            area = PI * Math.Pow(radius,2);
            return area;
        }
    }
}

