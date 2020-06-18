

//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://bgcoder.com/Contests/221/CSharp-Part-2-2015-2016-5-March-2015-Evening

//At long last scientist found out that the cats have an evil plan to enslave all of humanity.The sinister organization Al cat-qaeda have been targeting high profile programmers and taking them down (a.k.a brutally murdering them), because they are the only ones that can ruin their plans.
//“But why programmers?” you would ask, because they are the only ones that can write a program to crack their communication codes.They are using a 23-based numeral system in order to fool everyone that they are stupid and harmless beings.The digits go as following:
//a b  c d  …	j k  …	w
//0	1	2	3	…	9	10	…	22

//Your task is to help the global programmer community.You will receive a set on letter-numbers (strings) on one line separated with a single space ‘ ‘. Sum all of the letter-numbers and print out the resulting sum both in the 23-based system and decimal system as shown in the examples.
//Input
//The input data should be read from the console.
//The input data consists of a single string that needs to be split.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//Print out the sum of the given numbers in the format “[sum in 23-base numeral system] = [sum in decimal system]”.
//Constraints
//•	The number of letters-numbers will be between 1 and 10, inclusive.
//•	All of the given letter-numbers will consist of small characters.
//•	None of the letter-numbers will start with an ‘a’.
//•	The sum will always be between 0 and 2 147 483 647.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//ExamplesExample input   Example output     Explanation
//mia                      mia = 6532           mia = [12][8][0] = 12 * 23 * 23 + 8 * 23 + 0 * 1 =
//= 6348 + 184 + 0 = 6532

//grrrr miao miao          htksw = 2195786      //  grrrr = … =  1895286
//                                                 miao = … =  150250
//                                                 miao = … =  150250


//                                                 resulting sum =>  htksw = 2195786



namespace _06.CalculationProblem
{
   using System;
   using System.Linq; //for .Select() and .Sum()


   class CalculationProblem
   {
      //1.Read Input
      //2. Convert Every Number to it's Decimal Value
      //3. Sum
      //4. Convert the Sum to Meow Numeral System
      //5. Print the Result

      static int MeowToDec(string meow)
      {
         int result = 0;
         foreach (var digit in meow)
         {
            result = (digit - 'a') + result * 23;
         }

         return result;
      }

      static string DecToMeow(int dec)
      {
         var result = string.Empty;
         do
         {
            char digit = (char)('a' + (dec % 23));
            result = digit + result;
            dec /= 23;

         } while (dec > 0);

         return result;
      }


      static void Main()
      {
         var sum = Console.ReadLine().Split(' ').Select(MeowToDec).ToArray().Sum(); //

         //var sum = 0;
         //foreach (var n in catNumbers)
         //{
         //   sum = +n;
         //}

         var answer = DecToMeow(sum) + " = " + sum;

         Console.WriteLine(answer); 
      }
   }
}
