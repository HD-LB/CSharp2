//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/143/CSharp-Part-2-2013-2014-24-Jan-2014-Evening

//Much coin, how money, such currency, so crypto.Wow.
//Doge is a very popular dog.He is so popular that there is a crypto currency named after him. The crypto currency is named DogeCoin. Doge loves his DogeCoins and wants to gather as much as he can. Help this cute little animal.
//Doge and the DogeCoins are placed on a grid consisting of NxM cells (N vertical cells, numbered from 0 to N-1 and M horizontal cells, numbered from 0 to M-1). Doge is always placed on location[0; 0]. Doge is allowed only to move in two directions(right and down).
//There are K coins on the grid.Two or more coins may be on the same location.There also might be a coin(s) where Doge starts (0, 0) and he automatically gathers them.
//Find the biggest possible amount of coins that Doge can gather when moving only down and right.
//Wow.
//Input
//The input data should be read from the console.
//On the first line there will be the numbers N and M, separated by a single space.
//On the second line there will be the number K – the number of the coins on the grid.
//On the next K lines there will be the X and Y coordinates for each coin, separated by a space.X means the number of the row counting from 0 and Y means the number of the column, counting from 0 where the coin is located.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Output the biggest possible amount of coins that Doge can gather when moving only down and right.
//Constraints
//•	The numbers N and M will be non-negative integers between 1 and 2000, inclusive.
//•	The number K will be a non-negative integer between 0 and 100000.
//•	The coordinates of the coins will always be within the given grid.
//•	Allowed working time for your program: 0.2 seconds.
//•	Allowed memory: 64 MB.

//Examples
//Input           Output      
//4 5
//7
//1 4
//0 3
//1 2
//2 1
//3 1
//1 2
//2 4	            4


//10 10
//11
//0 0
//1 1
//2 2
//3 3
//4 4
//5 5
//6 6
//7 7
//8 8
//8 9
//9 9	         11		


//4 4
//11
//1 1
//2 1
//1 2
//2 1
//3 3
//0 3
//3 0
//3 1
//3 3
//1 1
//1 0	          8




namespace _15.DogeCoin
{
   using System;
   using System.Linq;

   class DogeCoin
   {
      static void Main()
      {
         //Matrix
         int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
         int rows = dimensions[0];
         int cols = dimensions[1];

         int[,] coins = new int[rows, cols];


         //Reading the Coins
         int k = int.Parse(Console.ReadLine());

         for (int i = 0; i < k; i++)
         {
            string[] currentCoords = Console.ReadLine().Split(' ');
            int currentCoinRow = int.Parse(currentCoords[0]);
            int currentCoinCol = int.Parse(currentCoords[1]);

            coins[currentCoinRow, currentCoinCol]++; //there could be a few coins in one cell

         }


         int[,] dp = new int[rows, cols]; //Dinamic Programming

         for (int row = 0; row < rows; row++)
         {
            for (int col = 0; col < cols; col++)
            {
               int maxAbove = 0;
               int maxLeft = 0;

               if (row - 1 >= 0)
               {
                  maxAbove = dp[row - 1, col];
               }

               if (col - 1 >= 0)
               {
                  maxLeft = dp[row, col - 1];
               }

               dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];

            }
         }
         Console.WriteLine(dp[rows - 1, cols - 1]); //the last Row and the last Column of the Matrix

      }
   }
}
