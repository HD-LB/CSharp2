using System;
using System.Linq;
using System.Numerics;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.Use variable number of arguments.Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

//Input
//•On the first line you will receive 5 numbers separated by spaces

//Output
//•Print their minimum, maximum, average, sum and product ◦Each on a new line
//◦The average value should be printed with two digits of precision


//Constraints
//•Each of the five numbers will be in the interval[-1000, 1000]
//•Time limit: 0.1s
//•Memory limit: 16MB

//Input: 3 7 9 18 0

//Output: 0
//        18
//        7.40
//        37
//        0 



namespace _14.IntegerCalculations
{
   class IntegerCalculations
   {

      static BigInteger CalculateProduct(int[] array)
      {
         BigInteger product = 1;
         for (int i = 0; i < array.Length; i++)
         {
            product *= array[i];
         }
         return product;
      }

      static int CalulateSum(int[] array)
      {
         int sum = 0;
         for (int i = 0; i < array.Length; i++)
         {
            sum += array[i];
         }
         return sum;
      }

      static double CalculateAverage(int[] array)
      {
         double avr = 0;
         for (int i = 0; i < array.Length; i++)
         {
            avr += array[i];
         }
         avr /= array.Length;
         return avr;
      }

      static int CalculatMax(int[] array)
      {
         int max = int.MinValue;
         for (int i = 0; i < array.Length; i++)
         {
            if (array[i] > max)
            {
               max = array[i];
            }
         }
         return max;
      }

      static int CalculateMin(int[] array)
      {
         int min = int.MaxValue;
         for (int i = 0; i < array.Length; i++)
         {
            if (array[i] < min)
            {
               min = array[i];
            }
         }
         return min;
      }


      //static int[] ConvertToArray(string number)
      //{
      //   int[] num = number
      //              .Split(' ')
      //              .Select(int.Parse)
      //              .ToArray();
      //   return num;
      //}


      static void Main()

      {
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < n; i++)
         {
            Console.Write("Array [{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
         }

         //var array = ConvertToArray(Console.ReadLine());

         Console.WriteLine("The calculated Product is: {0}", CalculateProduct(array));
         Console.WriteLine("The calculated Sum is: {0}", CalulateSum(array));
         Console.WriteLine("The Average is: {0}", CalculateAverage(array));
         Console.WriteLine("The Max is: {0}", CalculatMax(array));
         Console.WriteLine("The Min is: {0}", CalculateMin(array));
      }
   }
}
