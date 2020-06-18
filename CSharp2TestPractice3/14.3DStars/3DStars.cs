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
//Input                             Output 
//4 3 5
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAA
//AAAA AAAA AAAA AAAA AAAA            6
//                                    A 6		


//Input
//7 4 3
//BRYYYYY RYYYYGY YRYYYYY
//YYYGBGY YYYYGGG YYYGGGY
//RYBYGYY RYYYYGY RYBYGBB
//RYBYGYY RBYYGYY RYBYGBB	             4
//                                     G 1
//                                     Y 3




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._3DStars
{
   class Program
   {
      private static int width, height, depth, startCount;
      private static char[,,] cube;
      private static Dictionary<char, int> starType = new Dictionary<char, int>();


      static void Main()
      {
         ReadInput();
         FindStars();
         PrintMessage();
      }


      private static void PrintMessage()
      {
         var sorted = starType.OrderBy(x => x.Key);

        
         Console.WriteLine(startCount);

         foreach (var star in sorted)
         {
            Console.WriteLine("{0} {1}", star.Key, star.Value);
         }
      }



      private static void FindStars()
      {
         for (int w = 1; w < width - 1; w++)
         {
            for (int h = 1; h < height - 1; h++)
            {
               for (int d = 1; d < depth - 1; d++)
               {
                 FindSingleStar(w, h, d);

               }
            }
         }
      }


      private static void FindSingleStar(int currWidth, int currHeight, int currDepth)
      {
         char currChar = cube[currWidth, currHeight, currDepth];

         bool isStar =
                      currChar == cube[currWidth - 1, currHeight, currDepth] &&
                      currChar == cube[currWidth + 1, currHeight, currDepth] &&
                      currChar == cube[currWidth, currHeight - 1, currDepth] &&
                      currChar == cube[currWidth, currHeight + 1, currDepth] &&
                      currChar == cube[currWidth, currHeight, currDepth - 1] &&
                      currChar == cube[currWidth, currHeight, currDepth + 1];

         if (isStar)
         {
            startCount++;

            if (starType.ContainsKey(currChar))
            {
               starType[currChar]++; //if there is a Star, counted 
            }
            else
            {
               starType.Add(currChar, 1);
            }
         }
      }

      

      private static void ReadInput()
      {
         string[] rawNumbers = Console.ReadLine().Split();

         width = int.Parse(rawNumbers[0]);
         height = int.Parse(rawNumbers[1]);
         depth = int.Parse(rawNumbers[2]);

         cube = new char[width, height, depth];

         for (int h = 0; h < height; h++)
         {
            string[] lineFragment = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
               string cubeContent = lineFragment[d];

               for (int w = 0; w < width; w++)
               {
                  cube[w, h, d] = cubeContent[w];

               }

            }

         }
      }
   }
}
