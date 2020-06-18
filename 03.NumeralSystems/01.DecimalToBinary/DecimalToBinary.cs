using System;

//Write a program that converts a decimal number N to its binary representation.

//Input
//•On the only line you will receive a decimal number - N ◦There will not be leading zeros


//Output
//•Print the binary representation of N on a single line ◦There should not be leading zeros


//Constraints
//•1 <= N <= 1018
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 19

//Output: 10011




namespace _01.DecimalToBinary
{
   class DecimalToBinary
   {

      static string DecToBi(int number, int numBase)
      {
         string result = string.Empty;
         do
         {
            int digit = number % numBase;
            number /= numBase;
            result = digit + result;
         }
         while (number > 0);

         return result;
      }

      static void Main()
      {
         int number = int.Parse(Console.ReadLine());
         Console.WriteLine(DecToBi(number, 2));
      }
   }
}
