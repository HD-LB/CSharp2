using System;
using System.Numerics;

//Description

//Write a method that multiplies a number represented as an array of digits by a given integer number.Write a program to calculate N!.

//Input
//•On the first line you will receive the number N

//Output
//•Print N!

//Constraints
//•0 <= N <= 100
//•Time limit: 0.1s
//•Memory limit: 16MB

//Input: 5

//Output: 120


namespace _10.NFactorial
{
   class NFactorial
   { 
      static BigInteger CalculateFactorial(int[] number)
      {
         BigInteger result = 1;

         for (int i = 0; i < number.Length; i++)
         {
            result *= number[i];
         }

         //while (i > 0)
         //{
         //   result *= i;
         //   i--;
         //}
         return result;
      }


      static int[] ConvertToArray(int number)
      {
         int[] numberArray = new int[number];
         for (int i = 0; i < number; i++)
         {
            numberArray[i] = i + 1;
         }
         return numberArray;
      }

      static void Main()
      {
         int number = int.Parse(Console.ReadLine());
         int[] array = ConvertToArray(number);
         BigInteger result = CalculateFactorial(array);
         Console.WriteLine(result);
      }
   }
}
