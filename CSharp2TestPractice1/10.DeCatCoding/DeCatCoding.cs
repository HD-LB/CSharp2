//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://my.telerikacademy.com/Courses/LectureResources/Video/8369/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-DeCatCoding-%d0%9a%d0%be%d1%86%d0%b5%d1%82%d0%be

//http://bgcoder.com/Contests/223/CSharp-Part-2-2015-2016-6-March-2015-Evening

//At long last scientist found out that the cats have an evil plan to enslave all of humanity.The sinister organization Al cat-qaeda have been targeting high profile programmers and taking them down (a.k.a brutally murdering them), because they are the only ones that can ruin their plans.
//“But why programmers?” you would ask, because they are the only ones that can write a program to crack their communication codes.They are using a 21-based numeral system in order to fool everyone that they are stupid and harmless beings.The digits go as following:
//a b  c d  …	j k  …	u
//0	1	2	3	…	9	10	…	20

//Your task is to help the global programmer community.You will receive a set on letter-numbers (strings) on one line separated with a single space ‘ ‘. You have to decode every word transferring it from 21-based numeral system to 26-based numeral system(the whole English alphabet).
//For example, if you have the word “cb” in decimal system that will be 2*21 + 1*1 = 43. That in 26-based system is 43 % 26 = 17 = ‘r’, 1 % 26 = 1 = ‘b’. So in 21-based “cb” is “br” in 26.based system.
//Input
//The input data should be read from the console.
//The input data consists of a single string that needs to be split.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//Print out the decoded words separated by a single space.
//Constraints
//•	The number of letters-numbers will be between 3 and 20, inclusive.
//•	All of the given letter-numbers will consist of small characters.
//•	None of the letter-numbers will start with an ‘a’.
//•	The words in decimal system will always be between 0 and 18 446 744 073 709 551 615.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples:

//Example input     Example output        Explanation
//miao miao miao    gnqo gnqo gnqo         miao = [12][8][0][14] =
//                                        = 12 * 21 * 21 * 21 + 8 * 21 * 21 + 0 * 21 + 14 * 1 =
//                                        = 111132 + 3528 + 0 + 14 = 114674

//                                        114674 % 26 = 14 => o
//                                        4410 % 26 = 16 => q
//                                        169 % 26 = 13 => n
//                                        6 % 26 = 6 => g
//                                        miao => gnqo




//sgfcg bdgaj fbo   human must die         sgfcg = … = human
//                                         bdgaj = … = must
//                                         fbo = … = die



namespace _10.DeCatCoding
{
   using System;
   using System.Linq;


   class DeCatCoding
   {

      //1. Read Input
      //1.1. Extract all Cat Numbers from the Input
      //2. Convert the Cat Numbers to Decimal
      //3. Convert all decimal to Base 26
      //4. Join by Slace and Print


      static ulong CatToDecimal(string catNumber)
      {
         //2.

         ulong result = 0;

         foreach (char digit in catNumber)
         {
            result = (ulong)(digit - 'a') + result * 21;

         }
         return result;
      }

      //3.

      static string DecTo26(ulong dec)
      {
         var result = string.Empty;
         do
         {
            char digitValue = (char)('a' + (dec % 26));
            result = digitValue + result;
            dec /= 26;

         } while (dec > 0);


         return result;
      }

      static void Main()
      {
         //1.

         var numbers = Console.ReadLine()
                               .Split(' ')
                               .Select(CatToDecimal)
                               .Select(DecTo26)
                               .ToArray();

         Console.WriteLine(string.Join(" ", numbers));
      }
   }
}
