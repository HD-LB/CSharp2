//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/52/CSharp-Part-2-2012-2013-4-Feb-2013-Morning

//Joro is a very nice dwarf, but he is a little greedy.He and his friend Gosho heard about a valley that they can collect lots of coins.Unfortunately they can also lose some of the coins.
//Joro and Gosho are given a set of maps which show a correct pattern of steps through the valley.Since Joro and Gosho are greedy dwarfs, they want you to help them find the correct pattern, so they can collect most coins.
//You are given a sequence of numbers, the coins in the valley, and a set of patterns.The coins in the valley are numbers from -1000 to 1000, meaning the dwarfs should either get 1000 coins, or leave 1000 coins.The set of patterns is represented as many arrays, each containing numbers.
//The patterns consist of numbers and show where the dwarfs should go from their current position in the valley. The dwarfs should follow the patterns exactly.
//Given the valley:


//And the following patterns, the routes to escape are as follows:





//The pattern is used as follows:
//Start from the first number in the valley (valley[0]) and add the number to the coins collected.Then use the first number in the pattern (pattern[0]) and go to position(0 + pattern[0]) in the valley.Collect the coins from position 0 + pattern[0] and go to position (0 + pattern[0]) + pattern[1] m collect the coins, etc…
//When all the numbers from the pattern are used, start the pattern from the top.
//The dwarfs escape the valley when they step on already visited position in the valley, or when they go out the valley (i.e.their current position + the number in the pattern is leading outside of the valley).
//Help the dwarfs and find the best pattern to use, so they can collect most coins.
//Input
//The input data should be read from the console.
//On the first line you will be given the valley - numbers separated with “, ” (comma and space).
//On the second line you will be given M – the number of patterns.
//On each of the next M lines you will be given numbers, separated with “, “(comma and space), representing the patterns.
//Output
//The output data should be printed on the console.
//The output should contain the maximal number of coins, that the dwarfs can collect using one of the patterns
//Constraints
//•	The numbers in the valley will be between 1 and 10 000 inclusive.
//•	M will be between 1 and 500
//•	Each pattern will contain at most 100 numbers
//•	Each of the numbers in the valley or in the patterns will be between -1000 and 1000
//•	Allowed work time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Example
//Input example                  Output example
//1, 3, -6, 7, 4 ,1, 12
//3
//1, 2, -3
//1, 3, -2
//1, -1	                                 21


namespace _19.GreedyDwarf
{
   using System;

   class GreedyDwarf
   {
      private static long ProcessPattern(int[] vally)
      {
         string[] rawNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
         int[] pattern = new int[rawNumbers.Length];

         for (int i = 0; i < pattern.Length; i++)
         {
            pattern[i] = int.Parse(rawNumbers[i]);
         }

         long coinSum = 0;
         coinSum += vally[0]; //it always starts from the forst Position

         bool[] visited = new bool[vally.Length];
         visited[0] = true;
         int currentPosition = 0;

         while(true)
         {
            for (int i = 0; i < pattern.Length; i++)
            {
               int nextMove = currentPosition + pattern[i];

               if (nextMove >= 0 && nextMove < vally.Length && !visited[nextMove])//the Move is in the Array and it hasn't beenvisitted
               {
                  coinSum += vally[nextMove];
                  visited[nextMove] = true;
                  currentPosition = nextMove;
               }
               else
               {
                  return coinSum;
               }
            }
         }                  
      }


      static void Main()
      {
         string[] rawNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

         int[] vallyNumbers = new int[rawNumbers.Length];

         for (int i = 0; i < vallyNumbers.Length; i++)
         {
            vallyNumbers[i] = int.Parse(rawNumbers[i]);
         }

         int numberOfPatterns = int.Parse(Console.ReadLine());
         long bestSum = long.MinValue; ;

         for (int i = 0; i < numberOfPatterns; i++)
         {
            long sum = ProcessPattern(vallyNumbers);

            if (sum > bestSum)
            {
               bestSum = sum;

            }
         }

         Console.WriteLine(bestSum);

      }
   }
}
