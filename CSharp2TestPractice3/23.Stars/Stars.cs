//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/7/Telerik-Academy-Exam-2-6-Feb-2012

//You are given a rectangular cuboid of size W(width), H(height) and D(depth) consisting of W* H * D cubes, each colored in some color.Each color is denoted by a unique capital letter from the Latin alphabet: 'Y' is yellow, 'R' is red, 'B' is blue, 'G' green, etc.A 3D star is a figure of size 3 x 3 x 3 consisting of 7 cubes colored in the same color staying in the following configuration: one cube is the star center and 6 cubes are stuck at its 6 sides (see the figure below).
//The figure below shows a sample cuboid consisting of 7 x 4 x 3 colored cubes(width = 7, height = 4, depth = 3) and how the 3D star figure looks like:

//Your task is to write a program that finds how many 3D stars exist in the cuboid.At the cuboid above there are 4 stars: 3 yellow and 1 green.A cube is allowed to be shared between several stars.
//Input
//The input data should be read from the console. At the first line 3 integers W, H and D are given separated by a space.These numbers specify the width, height and depth of the cuboid. At the next H lines the colors of the cubes in the cuboid are given as D sequences of exactly W letters. Each sequence of W letters is separated from the next with a single space.
//The input data will be correct and there is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//At the first line of the output print the total number of 3D stars in the cuboid. On the next few lines print the stars in the cuboid: color followed by a space and by amount found in the cuboid. Only colors with non-zero amount of stars should be listed.The colors should be listed in alphabetical order.
//Constraints
//•	The numbers W, H and D are all integers in the range [3…150].
//•	The letter sequence in the input consists of capital Latin latters only
//•	Allowed work time for your program: 0.25 seconds.
//•	Allowed memory: 32 MB.
//Examples

//Input                           Output  
//4 3 5
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAA          6
//                                  A 6		


//Input
//7 4 3
//BRYYYYY RYYYYGY YRYYYYY
//YYYGBGY YYYYGGG YYYGGGY
//RYBYGYY RYYYYGY RYBYGBB
//RYBYGYY RBYYGYY RYBYGBB	          4
//                                  G 1
//                                  Y 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Stars
{
   class Stars
   {
      static int width, height, depth;

      static int[] letterStarCount = new int[(int)('Z' + 1)];

      static int totalStarsCount = 0;

      static void Main()
      {

         char[,,] cube = InputCube();

         CalculateStarsCount(cube);

         Console.WriteLine(totalStarsCount);
         for (int i = 0; i < letterStarCount.Length; i++)
         {
            if (letterStarCount[i] != 0)
            {
               Console.WriteLine("{0} {1}", (char)i, letterStarCount[i]);
            }
         }
         
      }


      private static void CalculateStarsCount(char[,,] cube)
      {
         for (int currentHeight = 1; currentHeight < height - 1; currentHeight++)
         {
            for (int currentDepth = 1; currentDepth < depth - 1; currentDepth++)
            {
               for (int currentWidth = 1; currentWidth < width - 1 ; currentWidth++)
               {
                  Console.Write(cube[currentWidth, currentHeight, currentDepth]);
               }
               Console.Write(" ");
            }
            Console.WriteLine();
         }
      }


      private static void OutputCube(char[,,] cube)
      {
         for (int currentHeight = 0; currentHeight < height; currentHeight++)
         {
            for (int currentDepth = 0; currentDepth < depth; currentDepth++)
            {
               for (int currentWidth = 0; currentWidth < width; currentWidth++)
               {
                 if(IsStar(cube, currentWidth, currentHeight, currentDepth))
                  {
                     totalStarsCount++;

                     char symbol = cube[currentWidth, currentHeight, currentDepth];
                     letterStarCount[(int)symbol]++;
                  }
               }            
            }           
         }
      }


      private static bool IsStar(char[,,] cube, int currentWidth, int currentHeight, int currentDepth)
      {
         char center = cube[currentWidth, currentHeight, currentDepth];

         if (center != cube[currentWidth - 1, currentHeight, currentDepth])
         {
            return false;
         }
         if (center != cube[currentHeight, currentHeight - 1, currentDepth])
         {
            return false;
         }
         if (center != cube[currentWidth, currentHeight + 1, currentDepth])
         {
            return false;
         }
         if (center != cube[currentWidth + 1,currentHeight, currentDepth] )
         {
            return false;
         }
         if (center != cube[currentWidth, currentHeight, currentDepth + 1])
         {
            return false;
         }
         if (center != cube[currentWidth, currentHeight, currentDepth + 1])
         {
            return false;
         }


         return true;
      }


      private static char[,,] InputCube()
      {
         string[] dimentions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

         width = int.Parse(dimentions[0]);
         height = int.Parse(dimentions[1]);
         depth = int.Parse(dimentions[2]);

         char[,,] cube = new char[width, height, depth];

         for (int currentHeight = 0; currentHeight < height; currentHeight++)
         {
            string[] rows = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int currentDepth = 0; currentDepth < depth; currentDepth++)
            {
               string currentRow = rows[currentDepth];

               for (int currentWidth = 0; currentWidth < width; currentWidth++)
               {
                  cube[currentWidth, currentHeight, currentDepth] = currentRow[currentWidth];
               }
            }
         }

         return cube;
      }
   }
}
