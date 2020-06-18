using System;

//Write a program that shows the binary representation of given 16-bit signed integer number N(the C# type short).

//Input
//•On the only line you will receive a decimal number - N

//Output
//•Print the its binary representation on a single line ◦There should be exactly 16 digits of output


//Constraints
//•-215 <= N< 215
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 11                   -11

//Output:0000000000001011     1111111111110101 


namespace _08.BinaryShort
{
   class BinaryShort
   {
      static string ShortToBinary(short number)
      {
         string binNum = string.Empty;
         binNum = Convert.ToString(number, 2).PadLeft(16, '0');
         return binNum;
      }
      static void Main()
      {
         short number = short.Parse(Console.ReadLine());
         Console.WriteLine(ShortToBinary(number));
      }
   }
}
