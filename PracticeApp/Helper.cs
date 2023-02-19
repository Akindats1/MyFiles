using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApp
{
    public static class Helper
    {
        public static int[] FindMinMax(int[] arr, int n)
        {
            int min = arr[0];
            int max = arr[0];
            for(int i = 0; i < n; i++)
            {
                if(arr[i] < min) 
                {
                    min = arr[i];
                }
                else if(arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] answer = new int[3];
            answer[0] = min;
            answer[1] = max;
            answer[2] = min + max;
            return answer;
        }
    }
}