using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Lecture4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //- Write a C# method to find the largest value from three integer values.

            Console.WriteLine($"The highest number is: {FindLargestInt(8, 4, 5)}");


            //- Write a C# method to find the lowest value from three integer values.

            Console.WriteLine($"The lowest number is: {FindLowestInt(8, 4, 5)}");


            /*
            Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 

            Test Data:
            Input first integer: 15
            Input second integer: 12
            Sample Output         15
            */

            Console.WriteLine($"The closest to twenty number is: {FindClosestToTwenty(3, 14)}");



            //- Write a C# method to compute the sum of all the elements of an array of integers

            int[] ints = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine($"The sum of array entries calculated with LINQ method is: {ArraySumLINQ(ints)}");

            Console.WriteLine($"The sum of array entries calculated with For Loop method is: {ArraySumForLoop(ints)}");



            //- Write a C# method to get the larger value from array
            int[] ints2 = { 0, -20, 10, 30, -40, 50, -60, 70, 80, 99  };

            Console.WriteLine($"The largest value in array is: {GetLargestIntFromArray(ints2)}");


        }

        //- Write a C# method to find the largest value from three integer values.
        public static int FindLargestInt(int a, int b, int c)
        {
            int[] ary = { a, b, c };

            return ary.Max();
        }


        //- Write a C# method to find the lowest value from three integer values.
        public static int FindLowestInt(int a, int b, int c)
        {
            int[] ary = { a, b, c };

            return ary.Min();
        }

        /*
        Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        
        Test Data:
        Input first integer: 15
        Input second integer: 12
        Sample Output         15
        */

        public static int FindClosestToTwenty(int a, int b)
        {
            const int k = 20;

            if (a == b) 
            {
                return 0;
            }
            else if (a > 20 || b > 20 || a < 0 || b < 0)
            {
                throw new ArgumentException("The number must be in range 0 - 20!");
            }
            else if (k - a < k - b) 
            {
                return a;
            }
            else
            {
                return b;
            }

        }


        //- Write a C# method to compute the sum of all the elements of an array of integers

        //variant 1 with LINQ
        public static int ArraySumLINQ(int[] ary)
        {
            return ary.Sum();
        }


        //variant 2 with For Loop
        public static int ArraySumForLoop(int[] ary)
        {
            int sum = 0;

            for (int i = 0; i < ary.Length; i++)
            {
                sum = sum + ary[i];
            }

            return sum;
        }

        //- Write a C# method to get the larger value from array
        public static int GetLargestIntFromArray(int[] ary)
        {
            return ary.Max();
        }

    }
}
