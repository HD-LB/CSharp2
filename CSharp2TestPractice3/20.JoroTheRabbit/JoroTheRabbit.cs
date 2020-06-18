//http://my.telerikacademy.com/courses/Courses/Details/219

//http://my.telerikacademy.com/courses/Courses/Details/219

//Joro is a rabbit.But he is no ordinary rabbit – he just loves to jump around. But jumping around without any precalculated direction is too ordinary, so he likes jumping in just a given direction and to make it more fun, the jumping is done in a circle. By given terrain, help Joro find longest fun and not ordinary route of jumps.
//You are given the terrain as sequence of numbers.The terrain should form a circle, so the last number is before the first, and the first is after the last.

//Joro can enter the terrain from every position, jump only on numbers larger than the one he is on, only in direction left-to-right and with the same step. Joro’s jumping steps range from 1 to the size of the terrain. Joro cannot jump on position that he already visited.
//Example:
//In the sample above, the best route is -7, -5, -3, 1 with length 4 and step 6.


//Input
//The input data should be read from the console.
//On the first line you will be given the terrain- numbers separated with “, ” (comma and space).
//Output
//The output data should be printed on the console.
//The output should contain the maximal number of positions visited by Joro, using any of the possible steps.
//Constraints
//•	The numbers in the terrain will be between 1 and 2 500 inclusive.
//•	Each of the numbers in the terrain will be between -1000 and 1000
//•	Allowed working time for your program: 0.2 seconds.Allowed memory: 16 MB.
//Examples
//Input example                                  Output example
//1, -2, -3, 4, -5, 6, -7, -8	                        4
//1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0	                  11
//1, 1, 1	                                          1



namespace _20.JoroTheRabbit
{
   using System;

   class JoroTheRabbit
   {
      static void Main()
      {
         int[] numbers;

         string input = Console.ReadLine();
         string[] inputNumbers = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

         numbers = new int[inputNumbers.Length];

         for (int i = 0; i < numbers.Length; i++)
         {
            numbers[i] = int.Parse(inputNumbers[i]);
         }

         int bestPath = 0;

         for (int startIndex = 0; startIndex < numbers.Length; startIndex++)
         {
            for (int steps = 1; steps < numbers.Length; steps++)
            {
               int index = startIndex;
               int currentPath = 1;
               int next = index + steps;

               if (next >= numbers.Length)
               {
                  next -= numbers.Length;
               }

               //next = (index + steps) % numbers.Length;


               while (numbers[index] < numbers[next]) //next != startIndex && 
               {
                  currentPath++;
                  index = next;

                  next = (index + steps) % numbers.Length;
               }

               if (bestPath < currentPath)
               {
                  bestPath = currentPath;
               }

            }
         }

         Console.WriteLine(bestPath);
      }
   }
}
