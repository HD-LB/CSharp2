using System;
//Write a program that converts a decimal number N to its hexadecimal representation.

//Input
//•On the only line you will receive a decimal number - N ◦There will not be leading zeros


//Output
//•Print the hexadecimal representation of N on a single line ◦There should not be leading zeros
//◦Use uppercase letters


//Constraints
//•1 <= N <= 1018
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 19

//Output: 13


namespace _03.DecimalToHexadecimal
{
   class DecimalToHexadecimal
   {

      static string DecToHex(int decValue)
      {
         string result = string.Empty;
         string hexDigits = "0123456789ABCDEF";
         do
         {
            int value = decValue % 16;
            result = hexDigits[value] + result;
            decValue /= 16;
         } while (decValue != 0);

         return result;
      }
      static void Main()
      {
         int decNum = int.Parse(Console.ReadLine());
         Console.WriteLine(DecToHex(decNum));
      }
   }
}
