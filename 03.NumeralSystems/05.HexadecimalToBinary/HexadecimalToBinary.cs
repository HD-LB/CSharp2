using System;
using System.Collections.Generic;
//Write a program to convert hexadecimal numbers to binary numbers(directly).

//Input
//•On the only line you will receive a decimal number - N ◦There will not be leading zeros
//◦Letters will be uppercase


//Output
//•Print the its binary representation on a single line ◦There should not be leading zeros


//Constraints
//•1 <= N <= 1018 = DE0B6B3A7640000(16)
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 13

//Output: 10011


namespace _05.HexadecimalToBinary
{
   class HexadecimalToBinary
   {
      static Dictionary<char, string> HexBin = new Dictionary<char, string>()
      {
         {'0', "0000"},
         {'1', "0001"},
         {'2', "0010"},
         {'3', "0011"},
         {'4', "0100"},
         {'5', "0101"},
         {'6', "0110"},
         {'7', "0111"},
         {'8', "1000"},
         {'9', "1001"},
         {'A', "1010"},
         {'B', "1011"},
         {'C', "1100"},
         {'D', "1101"},
         {'E', "1110"},
         {'F', "1111"},

      };

      static string HexToBin(string hex)
      {
         string result = string.Empty;
         foreach (char hexDigit in hex)
         {
            result = result + HexBin[hexDigit] ;
         }

         return result;
      }


      static void Main()
      {
         string digit = Console.ReadLine();
         Console.WriteLine(HexToBin(digit));
      }
   }
}
