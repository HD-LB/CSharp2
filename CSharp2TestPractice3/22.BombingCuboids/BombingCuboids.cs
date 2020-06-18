//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/9/Telerik-Academy-Exam-2-8-Feb-2012

//You are given a rectangular cuboid of size W(width), H(height) and D(depth) consisting of W* H * D cubes, each colored in some color.Each color is denoted by a unique capital letter from the Latin alphabet: 'Y' is yellow, 'R' is red, 'B' is blue, 'G' green, etc.When a bomb with power p is detonated at certain position { w, h, d}
//inside the cuboid it destroys all the cubes around it which are located at distance ≤ p from the bomb, while all other cubes remain unaffected.
//After a detonation the destroyed cubes leave an empty space in the cuboid and the cubes staying above them fall down due to the gravitation and fill the empty space.The fall down process moves the cubes to smaller coordinates by the 'height' axis.
//The distance between the bomb and given cube is calculated as standard Euclidian distance in the 3D space from the bomb's center to the given cube's center.For example, the distance between a bomb located at position { 5, 6, 2}
//and the cube at position {3, 0, 4} is approximately 6.63324958.
//At the figure below a cuboid of size 5 x 4 x 3 is shown and the detonation of a bomb with power 2 at coordinates {0, 0, 0} is illustrated along with the cubes fall down after it:

//Your task is to write a program which enters a cuboid from the console and simulates over it a sequence of N bomb explosions(at given coordinates and with given power) and calculates how many cubes of each color are destroyed by the bomb attack.
//All explosions happen one after another: the first bomb is detonated, it creates an empty space in the cuboid, the cubes above the empty space fall down, then the second bomb is detonated, etc.
//Input
//The input data should be read from the console. At the first line 3 integers W, H and D are given separated by a space.These numbers specify the width, height and depth of the cuboid. At the next H lines the colors of the cubes in the cuboid are given as D sequences of exactly W letters. Each sequence of W letters is separated from the next with a single space. At the next line a single integer N is given – the number of bombs. At the next N lines the bombs are given, each as a sequence of 4 integers separated by a space: w, h, d, and p.
//The input data will be correct and there is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//At the first line of the output print the total number cubes destroyed.On the next few lines print the cubes destroyed by colors in the following format: color followed by a space and by amount. Only colors with non-zero amount of cubes should be listed.The colors should be listed in alphabetical order.
//Constraints
//•	The numbers W, H and D are all integers in the range [1…100].
//•	The letter sequence in the input consists of capital Latin latters only
//•	The number N is an integer in the range [0…20].
//•	The value w is an integer in the range [0…W-1].
//•	The value h is an integer in the range [0…H-1].
//•	The value d is an integer in the range [0…D-1].
//•	The value p is an integer in the range [1…50].
//•	Allowed work time for your program: 0.15 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input                             Output  

//4 3 5
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAC
//ABAA AAAA AAAA AAAA AAAA
//3
//1 2 3 1
//0 0 0 2
//0 0 0 2	                           22
//                                     A 21
//                                     B 1		 

//Input

//7 4 3
//BRYYYYY RYYYYGY YRYYYYY
//YYYGBGY YYYYGGG YYYGGGY
//RYBYGYY RYYYYGY RYBYGBB
//RYBYGYY RBYYGYY RYBYGBB
//2
//6 3 2 4
//1 1 1 2	                           72
//                                     B 10
//                                     G 14
//                                     R 6
//                                     Y 42


//Note that in the first example the first line of letters is the bottom of the cuboid (h= 0) and the last line of letters(h= 2) is the top of the cuboid.More precisely, the letter "B" at the first example is located at position {1, 2, 0} and the letter "C" is located at position {3, 1, 4}. 
//At the both examples the locations of the explosions are shown in gray background.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.BombingCuboids
{
   class BombingCuboids
   {
      static int[] lettersHitCount = new int[91];

      static int totalHit = 0;

      const char Empty = ' ';



      static void Main()
      {
         //The Cube
         int width, height, depth;

         string[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         width = int.Parse(dimentions[0]);
         height = int.Parse(dimentions[1]);
         depth = int.Parse(dimentions[2]);

         char[,,] cube = InputCube(width, height, depth);

         //The Bomb
         int bombsCount = int.Parse(Console.ReadLine());
         for (int i = 0; i < bombsCount; i++)
         {
            string[] bombValues = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int bombWidth = int.Parse(bombValues[0]),
                bombHeight = int.Parse(bombValues[1]),
                bombDepth = int.Parse(bombValues[2]),
                power = int.Parse(bombValues[3]);

            DetonateBomb(cube, bombWidth, bombHeight, bombDepth, power);

            FallDown(cube);
         }

         PrintResult();

         //PrintCube(width, height, depth, cube);
      }



      private static void PrintResult()
      {
         Console.WriteLine(totalHit);

         for (int i = 0; i < lettersHitCount.Length; i++)
         {
            if (lettersHitCount[i] != 0)
            {
               Console.WriteLine("{0} {1}", (char)i, lettersHitCount[i]);
            }
         }
      }



      private static void FallDown(char[,,] cube)
      {
         int width = cube.GetLength(0);
         int height = cube.GetLength(1);
         int depth = cube.GetLength(2);

         for (int pillarWidth = 0; pillarWidth < width; pillarWidth++)
         {
            for (int pillarDepth = 0; pillarDepth < depth; pillarDepth++)
            {

               FallDownPillar(cube, pillarWidth, pillarDepth);
            }

         }
      }



      private static void FallDownPillar(char[,,] cube, int pillarWidth, int pillarDepth)
      {
         int pillarHeight = cube.GetLength(1);

         int bottom = 0;

         for (int currentHeight = 0; currentHeight < pillarHeight; currentHeight++)
         {
            if (cube[pillarWidth, currentHeight, pillarDepth] != Empty)
            {
               if (currentHeight != bottom)
               {
                  cube[pillarWidth, bottom, pillarDepth] = cube[pillarWidth, currentHeight, pillarDepth];
                  cube[pillarWidth, currentHeight, pillarDepth] = Empty;                  
               }

               bottom++;
            }
         }
      }



      private static void DetonateBomb(char[,,] cube, int bombWidth, int bombHeight, int bombDepth, int power)
      {
         int width = cube.GetLength(0);
         int height = cube.GetLength(1);
         int depth = cube.GetLength(2);

         for (int currentWidth = 0; currentWidth < width; currentWidth++)
         {
            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
               for (int currentDepth = 0; currentDepth < depth; currentDepth++)
               {
                  if (cube[currentWidth, currentHeight, currentDepth] != Empty)
                  {
                     int distanceSquarred = GetDistanceSquarred(currentWidth, currentHeight, currentDepth, bombWidth, bombHeight, bombDepth);
                     int pSquarred = power * power; //the power of the bomb

                     if (distanceSquarred <= pSquarred)
                     {
                        //The Cell is hit
                        char currentLetter = cube[currentWidth, currentHeight, currentDepth];
                        lettersHitCount[(int)currentLetter]++;
                        totalHit++;

                        cube[currentWidth, currentHeight, currentDepth] = Empty;
                     }
                  }
               }

            }

         }
      }



      private static int GetDistanceSquarred(int currentWidth, int currentHeight, int currentDepth, int bombWidth, int bombHeight, int bombDepth)
      {
         int deltaWidth = currentWidth - bombWidth,
             deltaHeight = currentHeight - bombHeight,
             deltaDepth = currentDepth - bombDepth;


         return (deltaWidth * deltaWidth) + (deltaHeight * deltaHeight) + (deltaDepth * deltaDepth); //Pythagoras Theorem

      }



      private static void PrintCube(int width, int height, int depth, char[,,] cube)
      {
         for (int currentHeight = 0; currentHeight < height; currentHeight++)
         {
            for (int currentDepth = 0; currentDepth < depth; currentDepth++)
            {
               for (int currentWidth = 0; currentWidth < width; currentWidth++)
               {
                  Console.Write(cube[currentWidth, currentHeight, currentDepth]);
               }
               Console.Write(" ");
            }
            Console.WriteLine();
         }
      }


      private static char[,,] InputCube(int width, int height, int depth)
      {

         char[,,] cube = new char[width, height, depth];

         for (int currentHeight = 0; currentHeight < height; currentHeight++)
         {
            string[] plateRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int currentDepth = 0; currentDepth < depth; currentDepth++)
            {
               string currentPlateRow = plateRow[currentDepth];

               for (int currentWidth = 0; currentWidth < width; currentWidth++)
               {
                  cube[currentWidth, currentHeight, currentDepth] = currentPlateRow[currentWidth];
               }
            }
         }

         return cube;
      }
   }
}
