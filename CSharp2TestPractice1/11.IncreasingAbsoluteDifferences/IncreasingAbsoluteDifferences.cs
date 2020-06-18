

//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://bgcoder.com/Contests/223/CSharp-Part-2-2015-2016-6-March-2015-Evening

//Sid is a small and smart kitten.
//She loves to eat programming books(and read them).
//When Sid reads books she remembers some of the terms and then combines them and creates programming tasks.
//In this case Sid combined “Absolute difference”, “Sequence of absolute differences” and “Increasing sequence” into a problem called “Increasing Absolute Difference”. It is the problem you are reading right now.Solve the problem that this kitten created and disprove her allegation that you are a bad programmer. 
//Absolute difference between two integer numbers A and B is the difference of the larger between A and B minus the smaller between A and B. Examples:
//•	Absolute difference between 5 and 1 is 4 (5 – 1 = 4).
//•	Absolute difference between -2 and -2 is 0 (-2 – -2 = 0).
//•	Absolute difference between 1 and 4 is 3 (4 – 1 = 3).
//If you are given a list of numbers, the sequence of absolute differences of the given list is constructed by taking all absolute differences between all two consecutive numbers.Examples:
//•	In the list “0 1 2 3 5” it’s sequence of absolute differences is “1 1 1 2”
//	011121325
//•	In the list “-2 -2 -1 0 2 4 1 5” it’s sequence of absolute differences is “0 1 1 2 2 3 4”
//	-20-21-11022243145
//•	In the list “3 2 4 8” it’s sequence of absolute differences is “1 2 4”
//	3122448
//Increasing sequence is a zero-based sequence of numbers(called seq) in which the absolute difference between every 2 consecutive numbers is 0 or 1 and for every i(from 1 to N-1) seq[i - 1]<=seq[i]. Examples:
//•	“1 1 2 2” is increasing sequence because 1<=1<=2<=2 and
//	1011202
//•	“0 1 1 2 2 3 4” is increasing sequence because 0<=1<=1<=2<=2<=3<=4 and
//	0110112021314
//•	“1 2 1” is NOT increasing sequence because 2>1.
//	11211
//•	“1 2 4” is NOT increasing sequence because the absolute difference between numbers 2 and 4 is 2:
//	11224
//You are given sequences of numbers.For each sequence find if the sequence of absolute differences in the given sequence is an increasing sequence or not.See examples below for clarification.
//Input
//The input data should be read from the console.
//On the first line there will be a single integer number T – the number of sequences you will be given.
//On each of the next T lines there will be a sequence of numbers for which you must find if the sequence of absolute differences in the given sequence is an increasing sequence or not.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//For each of the given T lines (sequences) write “True” or “False” depending on whether the sequence of absolute differences in the given sequence is an increasing sequence or not.
//Constraints
//•	T will be an integer between 4 and 10, inclusive.
//•	For each input sequence there will be between 2 and 20 numbers, inclusive.
//•	Each number will be between -2 000 000 000 and +2 000 000 000.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples               Example input     Example output     Explanation
//4                        True
//1 2 4 7 10               False
//-1 2 4 1 5               True
//-2 -2 -1 0 2 4 1 5       True
//3 2 4 1 4	
//
//	1122437310          1<=2<=3<=3
//-132243145          3>2 (2<=3<=4)
//-20-21-11022243145   0<=1<=1<=2<=2<=3<=4
//312243134           1<=2<=3<=3



//5
//0 1 2 3 5
//2 4 7
//4 7 4
//5 7 4
//3 2 4 8	True
//True
//True
//True
//False


//	011121325           1<=1<=1<=2
//22437              2<=3
//43734              3<=3
//52734              2<=3
//3122448             1<=2<=4 but 4-2=2
//Mew.


namespace _11.IncreasingAbsoluteDifferences
{

   using System;
   using System.Linq;


   class IncreasingAbsoluteDifferences
   {

      //1. Read Input
      //2. For every Sequence do the following:
         //2.1. Calculate Sequence of absolute Defferences
         //2.2. Check if the absolute Defferences Sequences is increasing
      //3. Output the Result


      static void Main()
      {

         var t = int.Parse(Console.ReadLine());

         for (int i = 0; i < t; i++)
         {
            var sequence = Console.ReadLine()
                                  .Split(' ')
                                  .Select(long.Parse)
                                  .ToArray();

            bool isIncreasing = true;

            for (int j = 2; j < sequence.Length; j++)
            {
               var lastAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
               var currentAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

               if (lastAbsDiff > currentAbsDiff || (currentAbsDiff - lastAbsDiff) > 1)
               {
                  isIncreasing = false;
                  break;
               }              
            }
            Console.WriteLine(isIncreasing);
         }       

      }
   }
}
