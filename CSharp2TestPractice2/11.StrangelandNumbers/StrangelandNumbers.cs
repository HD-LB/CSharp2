//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/143/CSharp-Part-2-2013-2014-24-Jan-2014-Evening

//Welcome to StrangeLand town! Absolutely everything is strange here! The location of the town is strange, people are strange, their houses are strange, the language they use is strange, their numeral system is strange and etc.Let’s talk about the StrangeLand numeral system.It consists of 7 digits, each one having a different length and all of them using lowercase and possibly uppercase letters from the Latin alphabet(and no – it’s not the alphabet that people use in StrangeLand, they have a really special one but that’s another story). Here are the StrangeLand digits and their decimal representations:
//0	f
//1	bIN
//2	oBJEC
//3	mNTRAVL
//4	lPVKNQ
//5	pNWE
//6	hT
//Recently Merry, a very skillful tennis player, found out about StrangeLand.She was very interested in the StrangeLand numeral system and wrote some numbers using it. Now she wants to know what their decimal representations are but she doesn’t know how to convert numbers from StrangeLand numeral system to numbers in decimal numeral system.You must help her by writing a program that converts a StrangeLand number to a decimal number knowing that the last digit of the number(the most right one) has a value as shown in the above table.The next digit on the left has a value 7 times bigger than the shown in the above table, the next digit on the left has 7*7 times bigger value than the shown in the table and so on.
//Input
//The input data consists of a single line – the StrangeLand number you must convert to a decimal number.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the decimal representation of the StrangeLand number.
//Constraints
//•	The input number will have between 1 and 24 digits.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


//Examples
//Input        Output         Input                 Output
//lPVKNQ	         4		      pNWEoBJECbINf           1820


//Input              Output      Input                                  Output
//bINoBJECpNWEhT      482		   hTmNTRAVLoBJEClPVKNQfffoBJECpNWE       37361980



namespace _11.StrangelandNumbers
{
   using System;
   using System.Numerics;

   class StrangelandNumbers
   {
      static void Main()
      {
         string strangeNumber = Console.ReadLine()
                                       .Replace("f", "0")
                                       .Replace("bIN", "1")
                                       .Replace("oBJECT", "2")
                                       .Replace("mNTRAVL", "3")
                                       .Replace("lPVKNQ", "4")
                                       .Replace("pNWE", "5")
                                       .Replace("hT", "6");

         int power = 0;

         BigInteger result = 0;       

         for (int i = strangeNumber.Length - 1; i >= 0; i--)
         {
            int currentNumber = strangeNumber[i] - '0';

            result += currentNumber * Power(7, power);

            power++;
         }

         Console.WriteLine(result);
      }


      static BigInteger Power(int number, int power)
      {
         BigInteger result = 1;

         for (int i = 0; i < power; i++)
         {
            result *= number;
         }

         return result;
      }
   }
}
