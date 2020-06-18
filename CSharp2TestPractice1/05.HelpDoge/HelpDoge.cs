


//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://my.telerikacademy.com/Courses/LectureResources/Video/8379/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-Help-Doge-%d0%9a%d1%80%d0%b8%d1%81%d1%82%d0%b8%d1%8f%d0%bd

//http://bgcoder.com/Contests/142/CSharp-Part-2-2013-2014-22-Jan-2014-Evening


//Doge and his food(bone) are placed on a grid consisting of NxM cells(N vertical cells, numbered from 0 to N-1 and M horizontal cells, numbered from 0 to M-1). Doge is always placed on location[0; 0] and his food is placed on location[Fx; Fy]
//(0 <= Fx <= N-1; 0 <= Fy <= M-1).
//Doge has K enemies.Each enemy is placed on the grid. Two enemies may be on the same location. There will not be an enemy on location [0; 0] (where Doge is) and there will not be an enemy on location[Fx; Fy] (where the food is).
//Doge is allowed only to move in two directions(right and down) and is not allowed to step on locations where his enemies are.
//Count and return the number of all possible ways for the Doge to go from his start location to the food.If there is no way for the Doge to go from his start position to the food, return 0. Wow.
//Input
//The input data should be read from the console.
//On the first line there will be the numbers N and M, separated by a single space.
//On the second line there will be the integer numbers Fx and Fy, separated by a single space.
//On the third line there will be the number K – the number of Doge`s enemies.
//On the next K lines there will be the X and Y coordinates for each Doge`s enemy, separated by a space.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Output the number of all possible ways for the Doge to go from his initial position to the food.
//Constraints
//•	The numbers N and M will be a non-negative integers between 1 and 500, inclusive.
//•	The number K will be a non-negative integer between 0 and 10000.
//•	Allowed working time for your program: 0.25 seconds.Allowed memory: 64 MB.
//•	Wow.
//Examples
//Input     
//4 5
//3 4
//3
//1 1
//2 2
//2 3	
//Output: 5
//// See the
//// picture
//// above		


//Input:
//10 12
//8 8
//4
//1 2
//7 3
//8 7
//3 5	
//Output: 2654


//Input
//12 15
//1 1
//3
//2 2
//3 3
//4 4	
//Output: 2


namespace _05.HelpDoge
{
   using System;
   using System.Numerics;


   class HelpDoge
   {
      //static int F(bool[,] matrix, int dogeX, int dogeY, int foodX, int foodY)
      //{
      //   if (dogeX == foodX && dogeY == foodY) //if Doge is on the food
      //   {
      //      return 1;
      //   }
      //   if (dogeX > foodX || dogeY > foodY) //if Doge is not on the food
      //   {
      //      return 0;
      //   }
      //   if (dogeX == matrix.GetLength(0)
      //      || dogeY == matrix.GetLength(1)
      //      || matrix[dogeX, dogeY]) //if the Doge has sptept outside the matrix ot Doge has sptept on an enemy 
      //   {
      //      return 0;
      //   }
      //   return F(matrix, dogeX + 1, dogeY, foodX, foodY) + F(matrix, dogeX, dogeY + 1, foodX, foodY); // the Doge is spteping to the right and down
      //}



      static void Main()
      {
         //Input: 

         string[] nm = Console.ReadLine().Split(' ');
         int n = int.Parse(nm[0]);
         int m = int.Parse(nm[1]);

         //Food
         nm = Console.ReadLine().Split(' ');
         int fx = int.Parse(nm[0]);
         int fy = int.Parse(nm[1]);


         //Enemies
         int k = int.Parse(Console.ReadLine()); // the coordinates of the enemy

         bool[,] matrix = new bool[fx + 1, fy + 1];// the matrix should be just as big as the food + 1
         for (int i = 0; i < k; i++)
         {
            nm = Console.ReadLine().Split(' ');
            int x = int.Parse(nm[0]);
            int y = int.Parse(nm[1]);

            if (x <= fx && y <= fy)
            {
               matrix[x, y] = true; // true means there is an enemy on this place
            }

         }

         BigInteger[,] count = new BigInteger[fx + 1, fy + 1];
         count[0, 0] = 1;

         for (int j = 1; j < count.GetLength(1); j++)//starting from the columns
         {
            count[0, j] = matrix[0, j] ? 0 : count[0, j - 1];
            //if (matrix[0, j]) //enemy
            //{
            //   count[0, j] = 0; //= 0 because the Doge can't go there
            //}
            //else
            //{
            //   count[0, j] = count[0, j - 1];
            //}
         }

         for (int i = 1; i < count.GetLength(0); i++) //the rows
         {
            count[i, 0] = matrix[i, 0] ? 0 : count[i - 1, 0];
         }

         for (int i = 1; i < count.GetLength(0); i++) //starting from 1, because the Doge is on [0, 0]
         {
            for (int j = 1; j < count.GetLength(1); j++)
            {
               count[i, j] = matrix[i, j] ? 0 : (count[i - 1, j] + count[i, j - 1]);
            }
         }

         
         Console.WriteLine(count[fx, fy]);
      }
   }
}
