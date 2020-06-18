//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/10/CSharp-Fundamentals-2011-2012-Part-2-Test-Exam

//Bobi is a guitar player and he is going to play a concert.He don't like to play all the songs at the same volume, so he decides to change the volume level of his guitar before each new song. Before the concert begins, he makes a list of the number of intervals he will be changing his volume level by before each song. For each volume change, he will decide whether to add that number of intervals to the volume, or subtract it.
//You are given a list of integers C, the i-th element of which is the number of intervals Bobi will change his volume by before the i-th song.You are also given an integer B, the initial volume of Bobi's guitar, and an integer M, the highest possible volume setting of Bobi's guitar. Bobi cannot change the volume of his guitar to a level above M or below 0 (but exactly 0 and exactly M is possible). Your program should print the maximum volume Bobi can use to play the last song.If there is no way to go through the list without exceeding M or going below 0, print -1.
//Input
//The input data should be read from the console.
//The elements of the list C will be on the first input line separated by a comma and an interval (", ").
//On the second line there will be the number B and on the third line there will be the number M.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only output line you should print -1 or the maximum volume Bobi can use to play the last song.
//Constraints
//•	C will contain between 1 and 50 elements, inclusive.
//•	In 95% of the tests cases C will contain no less than 34 elements.
//•	Each element of C will be between 1 and M, inclusive.
//•	M will be between 1 and 1000, inclusive.
//•	B will be between 0 and M, inclusive.
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input example   Output example
//5, 3, 7
//5
//10	            10


//Input example                                                         Output example
//74, 39, 127, 95, 63, 140, 99, 96, 154, 18, 137, 162, 14, 88
//40
//243                                                                      	238


//Input example      Output example
//15, 2, 9, 10
//8
//20	                     -1




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Guitar
{
   class Guitar
   {
      static void Main()
      {

         //Read Input
         string[] songsStrings = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

         int[] songs = new int[songsStrings.Length];

         for (int i = 0; i < songsStrings.Length; i++)
         {
            songs[i] = int.Parse(songsStrings[i]);
         }

         int start = int.Parse(Console.ReadLine());
         int max = int.Parse(Console.ReadLine());


         //Logic
         int[,] clever = new int[songs.Length + 1, max + 1];

         //Filling the Table
         clever[0, start] = 1;

         for (int i = 1; i < clever.GetLength(0); i++)
         {
            var interval = songs[i - 1];

            for (int j = 0; j < clever.GetLength(1); j++)
            {
               if (clever[i - 1, j] == 1) //the previuose row, and the current column
               {
                  if (j - interval >= 0)
                  {
                     clever[i, j - interval] = 1;
                  }

                  if (j + interval <= max)
                  {
                     clever[i, j + interval] = 1;
                  }
               }
            }
         }

         
         for (int i = max; i >= 0 ; i--)
         {
            if (clever[songs.Length, i] == 1)
            {
               Console.WriteLine(i);
               return;
            }
         }

         Console.WriteLine(-1);
      }
   }
}
