//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/143/CSharp-Part-2-2013-2014-24-Jan-2014-Evening


//Molly and Dolly are two cute little girls playing in a local park.They decided to compete with each other in an easy game – which one will collect more flowers.Since the girls are too young to calculate the final score, they need your help. And since you are too lazy to count by hand, you have to write a program to make it for you.
//The rules for the game follow:
//•	The game field is a circular path of N cells. Each cell may have F flowers in it.
//•	Each cell is numbered with integer from 1 to N.
//•	Molly and Dolly are collection flowers jumping from one cell to another.
//•	They start next to each other but moving in opposite directions.
//•	Molly starts at cell 1 and moves towards cell N.
//•	If Molly reaches cell N and has to move forward, she continues to cell 1 (circular path).
//•	Dolly starts at cell N and moves towards cell 1.
//•	If Dolly reaches cell 1 and has to move forward, she continues to cell N(circular path).
//•	When one of the girls reaches a cell, she collects all the F flowers on that cell.
//•	The girl then jumps F cells ahead of the current cell, depending on the moving direction.
//•	If one of the girls reaches a cell with no flowers in it, the game ends.
//•	If the both girls move at the same time to the same cell full of flowers, they split the flowers evenly and leave the rest into the cell. If the cell contains even amount of flowers, they split them in half and zero flowers are left in the cell. If the cell contains odd amount of flowers, they leave 1 flower in the cell and split the rest in half.
//•	If the both girls move at the same time to the same cell full of F flowers, they both jump F cells forward.
//•	The girls never change their moving directions.
//•	Both girls collect the flowers on their starting cell before moving to the next one.
//•	The two girls collect flowers and move at the same time.
//Detailed example:
//•	We have a path with 8 cells.
//•	Molly starts at cell 1 and collects 4 flowers.
//•	Dolly starts at cell 8 and collects 2 flowers.
//•	Molly moves 4 cells ahead jumping on cell 5.
//•	Dolly moves 2 cells ahead jumping on cell 6.
//•	Molly is at cell 5 and collects 7 flowers – 11 in total.
//•	Dolly is at cell 6 and collects 11 flowers – 13 in total.
//•	Molly moves 7 cells ahead jumping on cell 4.
//•	Dolly moves 11 cells ahead jumping on cell 3.
//•	Molly is at cell 4 and collects 2 flowers – 13 in total.
//•	Dolly is at cell 3 and collects 4 flowers – 17 in total.
//•	Molly moves 2 cells ahead jumping on cell 6.
//•	Dolly moves 4 cells ahead jumping on cell 7.
//•	Molly is at cell 6 but there are no flowers left.
//•	Dolly is at cell 7 and collects 3 flowers – 20 in total.
//Input
//The input data consists of one line – the path cells full of flowers, separated by space character (" ").
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consist of two lines.
//On the first line write down the girl, who did not reach an empty cell – "Molly", "Dolly" or "Draw", if both of them reach an empty cell at the same time.
//On the second line write down first the total amount of flowers Molly collected and then the total amount of flowers Dolly collected, separated by space character (" ").
//Constraints
//•	N will be between 2 and 1 000 inclusive.
//•	F will be between 0 and 9 200 000 000 000 000 000.
//•	All paths can be finished with above rules.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input                    Output
//4 17 4 2 7 11 3 2	      Dolly
//                         13 20




namespace _12.TwoGirlsOnePath
{
   using System;
   using System.Linq;
   using System.Numerics;

   class TwoGirlsOnePath
   {
      static void Main()
      {
         BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

         int mollyIndex = 0;
         int dollyIndex = numbers.Length - 1;

         BigInteger mollyTotalFlowers = 0;
         BigInteger dollyTotalFlowers = 0;

         string winner = string.Empty;

         while (true)
         {
            if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
            {
               if (numbers[mollyIndex] == 0 && numbers[dollyIndex] == 0)
               {
                  winner = "Draw";
               }
               else if (numbers[mollyIndex] == 0)
               {
                  winner = "Dolly";
               }
               else if (numbers[dollyIndex] == 0)
               {
                  winner = "Molly";
               }
               


               mollyTotalFlowers += numbers[mollyIndex];
               dollyTotalFlowers += numbers[dollyIndex];

               break;
            }

            BigInteger currentMollyFlowers = numbers[mollyIndex];
            BigInteger currentDollyFlowers = numbers[dollyIndex];

            if (mollyIndex == dollyIndex) //if both are on the same sell
            {
               numbers[mollyIndex] = currentMollyFlowers % 2;
               mollyTotalFlowers += currentMollyFlowers / 2;
               dollyTotalFlowers += currentDollyFlowers / 2;

            }
            else
            {
               numbers[mollyIndex] = 0; //no more Flowers in the ccells
               numbers[dollyIndex] = 0;

               mollyTotalFlowers += currentMollyFlowers; //collecting the Flowers
               dollyTotalFlowers += currentDollyFlowers;

            }                       

            mollyIndex = (int)((mollyIndex + currentMollyFlowers) % numbers.Length);

            dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);
            if (dollyIndex < 0)
            {
               dollyIndex += numbers.Length;
            }                       
         }
         Console.WriteLine(winner);
         Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
      }
   }
}
