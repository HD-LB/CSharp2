using System;

//Write a program that converts a binary number N to its decimal representation.

//Input
//•On the only line you will receive a binary number - N ◦There will not be leading zeros


//Output
//•Print the decimal representation of N on a single line ◦There should not be leading zeros


//Constraints
//•1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 10011

//Output: 19

namespace _02.BinaryToDecimal
{
   class BinaryToDecimal
   {

      static int BinaryToDec(string binary)
      {
         int sum = 0;

         foreach (char bit in binary)
         {
            sum = (bit - '0') + sum * 2;
         }

         return sum;
      }


      static void Main()
      {
         string binary = Console.ReadLine();
         Console.WriteLine(BinaryToDec(binary));
      }
   }
}
