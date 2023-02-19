using System;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
          double areaOfaTriangle = AreaOfATriangle(5,2);
          Console.WriteLine(areaOfaTriangle);

           PrintMultiplicationTable(3,12,0);


           Console.WriteLine("Enter name:");
           string name = Console.ReadLine();
           Console.WriteLine("Enter age:");
           int age = int.Parse(Console.ReadLine());

            Console.WriteLine(MGQSApplicant(name,age));

            DaysOfTheWeek();
            
            
        }

        static double AreaOfATriangle(double bse, double height)
        {
            double area;
            const double half =(double)1 / 2;
            
            area = half * bse * height;

            return area;

           
        }
        static void PrintMultiplicationTable(int number,int times,int countFrom = 1)
        {
            for(int i = countFrom; i <= times;i++)
            {
                Console.WriteLine($"{number}*{i} = {number * i}");
            }
        }


        static string MGQSApplicant(string name,int age)
        {
            if(age >= 14 && age <= 25)
            {
              return $"Welcome {name},you are {age} years old.You are eligible for the training!";
            
            }
            return "You are not eligible";
            

           
        }


        static void DaysOfTheWeek()
        {
            DateTime now = DateTime.Today;
            for(int i = 1;i <= 7;i++)
            {
                Console.WriteLine(now.ToString("ddd"));
                now = now.AddDays(1);
                
            }
        }

        

    }
}
