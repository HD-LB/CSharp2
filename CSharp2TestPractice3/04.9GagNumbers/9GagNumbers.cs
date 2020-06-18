//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/55/CSharp-Part-2-2012-2013-11-Feb-2013

//In 9Gag we like fun.We have a lot of time and we play with fun pictures and fun stories. Recently we invented a funny way to express numbers.We use the following 9 digits:
//0	-!
//1	**
//2	!!!
//3	&&
//4	&-
//5	!-
//6	*!!!
//7	&*!
//8	!!**!-
//We write the numbers as sequences digits from our 9 available digits given above. The last digit of the number (the most right one) has a value as shown in the above table.The next digit on the left has a value 9 times bigger than the shown in the above table, the next digit on the left has 9*9 times bigger value than the shown in the table and so on.Your task is to write a program to convert a 9Gag-style number into its corresponding decimal representation.
//Input
//The input data consists of a single string – a 9Gag-style number.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the calculated decimal representation of the given 9Gag-style number and should be printed at the console.
//Constraints
//•	The input number will have between 1 and 20 digits.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input   Output  Input    Output   Input       Output      Input          Output
//*!!!	   6		***!!!	  15		!!!**!-	     176		  !!**!--!!-	      653

namespace _04._9GagNumbers
{
   using System;
   using System;
   using System.Numerics;

   class Program
   {
      static string ConverGagStringToNumber(string digit)
      {
         string result = "NO";

         switch (digit)
         {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;

            default:
               break;
         }
         return result;
      }

      static BigInteger PowerOfNine(int power)
      {
         BigInteger resut = 1;

         for (int i = 0; i < power; i++)
         {
            resut *= 9;
         }

         return resut;
      }


      static void Main()
      {
         string input = Console.ReadLine();

         string partialInput = string.Empty;
         string nineSystemNumber = "";

         for (int i = 0; i < input.Length; i++)
         {
            partialInput += input[i];

            string currentDigit = ConverGagStringToNumber(partialInput);

            if (currentDigit != "NO")
            {
               nineSystemNumber += currentDigit;
               partialInput = ""; //setting it to 0 again, because it's read already
            }
         }
        

         BigInteger result = 0;

         for (int i = 0; i < nineSystemNumber.Length; i++)
         {
            BigInteger digit = BigInteger.Parse(nineSystemNumber[i].ToString());

            result += digit * PowerOfNine(nineSystemNumber.Length - i - 1);
         }
         Console.WriteLine(result);
      }
   }
}
