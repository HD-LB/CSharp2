//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/10/CSharp-Fundamentals-2011-2012-Part-2-Test-Exam

//You are given a rectangular cuboid of size W(width), H(height) and D(depth) consisting of W* H * D cubes, each colored in some color.Each color is denoted by a unique capital letter from the Latin alphabet: 'Y' is yellow, 'R' is red, 'B' is blue, 'G' green, etc.
//Two cubes are neighbors when they share a common side, common edge or common point.A 3D line is a sequence of neighbor cubes in the same color staying on the same horizontal, vertical, or diagonal in the cuboid. At the figure below few examples of 3D lines are shown:


//Your task is to write a program that finds the length of the longest 3D line and how many 3D lines with this length exist in the cuboid.
//Input
//The input data should be read from the console. At the first line 3 integers W, H and D are given separated by a space.These numbers specify the width, height and depth of the cuboid. At the next H lines the colors of the cubes in the cuboid are given as D sequences of exactly W letters. Each sequence of W letters is separated from the next with a single space.
//The input data will be correct and there is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//At the first line of the output print the length of the longest 3D line in the cuboid followed by a space and how many 3D lines with this length exist in the cuboid. If no lines exist in the cuboid print "-1" at the first line of the output.
//Constraints
//•	The numbers W, H and D are all integers in the range [1…50].
//•	The letter sequence in the input consists of capital Latin latters only
//•	Allowed work time for your program: 0.3 seconds.
//•	Allowed memory: 32 MB.
//Examples
//Input                                            Output  
//4 3 5
//AAAA AAAA ABAA AAAB AABA
//AAAA BBBA AABA AABA ABAA
//BBBB ABBB ABBB ABAB BBAA                          5 3


//Input
//7 4 3
//BRYYYYY RYYYYGY YRYYYYY
//YYYGBGY YYYYGGG YYYGGGY
//RBBBBBY RYYYYGY RYBYGBB
//RYBYGYY RBYYGYY RRRRRYB	                          5 4


//Input                                            Output       
//2 2 
//AB EF
//CD GH	                                            -1

		
//Input
//3 3 3
//AAD AXD BXD
//AXX XAX BXA
//CCC XXA BAA                                         3 7



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._3DLines
{
   class Program
   {
      private static char[,,] cube;
      private static int width, height, depth;
      private static int[] dirWidth = {1, 0, 1, -1, 0, 0, 0, 1, -1, 1, 1, 1, 1};
      private static int[] dirHeight = {0, 1, 0, 0, 0, 1, 1, 1, 1, 1, -1, 1, -1};
      private static int[] dirDepth = {0, 0, 1, 1, 1, 1, -1, 0, 0, 1, 1, -1, -1};
      private static int bestLineLength = 0;
      private static int bestNumberOfLines = 0;

      static void Main()
      {
         //Filling the Cube
         string[] rawNumbers = Console.ReadLine().Split();
         width = int.Parse(rawNumbers[0]);
         height = int.Parse(rawNumbers[1]);
         depth = int.Parse(rawNumbers[2]);
         cube = new char[width, height, depth];


         for (int h = 0; h < height; h++)
         {
            string line = Console.ReadLine();
            string[] lineFragment = line.Split();

            for (int d = 0; d < depth; d++)
            {
               string depthFragment = lineFragment[d];

               for (int w = 0; w < width; w++)
               {
                  cube[w, h, d] = depthFragment[w];
               }
            }
         }

         //Reading the Cube
         for (int w = 0; w < width; w++)
         {
            for (int h = 0; h < height; h++)
            {
               for (int d = 0; d < depth; d++)
               {
                  ProcessDirs(w, h, d);
               }
            }
         }

         Console.WriteLine("{0} {1}", bestLineLength, bestNumberOfLines);


      }

      private static void ProcessDirs(int w, int h, int d)
      {
         char curCell = cube[w, h, d];

         for (int i = 0; i < dirDepth.Length; i++)
         {
            int currentLineLength = 1;
            int curWidth = w;
            int curHeight = h;
            int curDepth = d;

            while (true)
            {
               curWidth += dirWidth[i];
               curHeight += dirHeight[i];
               curDepth += dirDepth[i];

               if (!IsInCube(curWidth, curHeight, curDepth))
               {
                  break;
               }

               if (cube[curWidth, curHeight, curDepth] == curCell)
               {
                  currentLineLength++; //moving to the nextCell
               }
               else
               {
                  break;
               }
            }

            if (currentLineLength > bestLineLength)
            {
               bestLineLength = currentLineLength;
               bestNumberOfLines = 1;
            }
            else if ( currentLineLength == bestLineLength)
            {
               bestNumberOfLines++;
            }

         }

      }

      private static bool IsInCube(int w, int h, int d)
      {
         if (w >= 0 && h >= 0 && d >= 0 &&            //in the cube
             w < width && h < height && d < depth)
         {
            return true;
         }
         else
         {
            return false; // not in the Cube
         }
      }
   }
}
