//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/7/Telerik-Academy-Exam-2-6-Feb-2012


//Marto is a well-known Pernik fighter.He has N tubes with different sizes.Marto also has M-1 friends.His friends also need tubes for fighting.
//Help Marto to cut his own tubes into exactly M parts with same sizes.This size should be maximal possible (bigger tube = better fighter).
//Your task is to write a program that finds the biggest possible size of the M tubes which you can cut from the initial Marto’s tubes.
//Input
//The input data should be read from the console.
//On the first input line your program should read the integer N – the number of Marto’s tubes.
//On the second input line there will be the number M – the count of the tubes Marto needs.
//On the next N lines your program should read the sizes of the Marto’s tubes Marto.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only output line you should print the maximal possible size of the M tubes. If it is impossible to cut the tubes with the given criteria write “-1” on the only output line.
//Constraints
//•	N will be between 1 and 20 000, inclusive.
//•	M will be between 1 and 2 000 000 000, inclusive.
//•	The sizes of the tubes will be between 1 and 2 000 000 000, inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input example    Output example
//3
//6
//100
//200
//300	              100


//Input example    Output example
//4
//11
//803
//777
//444
//555	                200


//In the first example we can cut the tubes into 6 parts (each with size of 100).
//In the second example we can cut the first tube into 5 parts(200, 200, 200, 200 and 3), the second tube into 4 parts(200, 200, 200 and 177), the third tube into 3 parts(200, 200 and 44) and the fourth tube into 3 parts(200, 200 and 155). After this cuts we have exactly 11 tubes with size of 200. The cuts we made are optimal. We can’t cut the tubes into 11 parts of size 201.

namespace _01.Tubes
{
   using System;

   class Tubes
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine()); // initial tubes
         int m = int.Parse(Console.ReadLine()); // fighters
         int[] tube = new int[n];

         int right = 0;
         int left = 0; //the left Limit
         int mid = 0;

         for (int i = 0; i < n; i++)
         {
            tube[i] = int.Parse(Console.ReadLine());

            if(right < tube[i])
            {
               right = tube[i]; //the right Limit, so the max Tube
            }
         }

         mid = (left + right) /  2; //mid is how many Tubes could get cut

         int maxTube = -1;
         int eventualTubes = 0;

         while (left <= right)
         {
            eventualTubes = 0;

            for (int i = 0; i < n; i++)
            {
               eventualTubes += tube[i] / mid;
            }

            if (eventualTubes >= m) //if the Tubes are >= than the given m, there is an answer
            {
               left = mid + 1;
               maxTube = mid;
            }
            else
            {
               right = mid - 1;
            }
            mid = (left + right) / 2;
         }
         Console.WriteLine(maxTube);
      }
   }
}
