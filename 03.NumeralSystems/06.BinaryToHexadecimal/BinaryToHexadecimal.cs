using System;
using System.Collections.Generic;
//Write a program to convert binary numbers to hexadecimal numbers(directly).

//Input
//•On the only line you will receive a decimal number - N ◦There will not be leading zeros


//Output
//•Print the its binary representation on a single line ◦There should not be leading zeros
//◦Use uppercase letters


//Constraints
//•1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 10011

//Output: 13


namespace _06.BinaryToHexadecimal
{
   class BinaryToHexadecimal
   {

      //TODO: 

      static Dictionary<string, char> BinHex = new Dictionary<string, char>()
      {
         {"0000", '0'},
         {"0001", '1'},
         {"0010", '2'},
         {"0011", '3'},
         {"0100", '4'},
         {"1010", '5'},
         {"0110", '6'},
         {"0111", '7'},
         {"1000", '8'},
         {"0000", '9'},
         {"0000", 'A'},
         {"0000", 'B'},
         {"0000", 'C'},
         {"0000", 'D'},
         {"0000", 'E'},
         {"0000", 'F'}

      };
      static string BinToHex(string bin)
      {
         string result = string.Empty;
         //foreach (var binDigit in bin)
         //{
         //   result = result + BinHex[binDigit];
         //}
         return result;
      }
      static void Main(string[] args)
      {
         string digit = Console.ReadLine();
         Console.WriteLine(BinToHex(digit));
      }
   }
}
