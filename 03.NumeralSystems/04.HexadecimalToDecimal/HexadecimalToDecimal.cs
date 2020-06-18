using System;
//Write a program that converts a hexadecimal number N to its decimal representation.

//Input
//•On the only line you will receive a hexadecimal number - N ◦There will not be leading zeros
//◦Letters will be uppercase


//Output
//•Print the decimal representation of N on a single line ◦There should not be leading zeros


//Constraints
//•1 <= N <= 1018 = DE0B6B3A7640000(16)
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 13

//Output: 19


namespace _04.HexadecimalToDecimal
{
   class HexadecimalToDecimal
   {
      //static int HexDigitToDecimal(char hexDigit)
      //{
      //   if (char.IsDigit(hexDigit))
      //   {
      //      return hexDigit - '0';
      //   }
      //   return hexDigit - 'A' + 10;
      //}

      static int ConvertFromHexToDec(string number)
      {
         int result = 0;

         foreach (char digit in number)
         {
            int digitValue;

            if (char.IsDigit(digit))
            {
               digitValue = digit - '0';
            }
            else
            {
               digitValue = digit - 'A' + 10;
            }
            result = 16 * result + digitValue;
         }

         return result;
      }
      static void Main()
      {
         //char[] hexDigit = "0123456789ABCDEF".ToCharArray();
         //foreach (char hex in hexDigit)
         //{
         //   Console.WriteLine("{0} - {1}", hex, HexDigitToDecimal(hex));
         //}



         string hexNum = Console.ReadLine();
         Console.WriteLine(ConvertFromHexToDec(hexNum));
      }
   }
}
