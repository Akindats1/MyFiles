using System;

namespace PracticeApp
{
  class Program
  {
    static void Main(string[] args)
    {
        
      Console.WriteLine("Enter the array length: ");
      int N = int.Parse(Console.ReadLine());

      int[] arr = new int[N];
      for(int i = 0; i < arr.Length; i++)
      {
        Console.WriteLine($"Enter elements of the array at index {i}: ");
        arr[i] = int.Parse(Console.ReadLine());
      }

    
        // Function call
      int[] result = Helper.FindMinMax(arr, N);
      Console.WriteLine("Maximum is: " + result[1]);
      Console.WriteLine("Minimum is: " + result[0]);
      Console.WriteLine("The sum is:  " + result[2]);
    }
       
  }
   
}




