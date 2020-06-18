
//http://bgcoder.com/Contests/142/CSharp-Part-2-2013-2014-22-Jan-2014-Evening

//http://my.telerikacademy.com/Courses/LectureResources/Video/8375/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-Bunny-Factory-%d0%9a%d1%80%d0%b8%d1%81%d1%82%d0%b8%d1%8f%d0%bd

//The bunny factory has N initial cages filled with bunnies.Each cage has more than 1 bunny (so that they can multiply without a problem). The multiplication process consists of several similar cycles and stop when a certain condition is met.On each i-th cycle of the multiplication factory goes through the following steps:
//1.	If there are less than i cages, the factory stops the multiplication process.
//2.	The factory gets the first i cages and calculate the sum s of all bunnies in them.
//3.	If there are less than s cages after the i-th one, the factory stops the multiplication process.
//4.	The factory gets the next s cages after the i-th one and calculates the sum and product of all bunnies in them.
//5.	These sum and product are concatenated as next cages. All cages that were not included in the calculations are simply appended to next.
//6.	The factory gets several empty cages then gets the digits of next and for each digit puts the same amount of bunnies in each cell. If the digit is 1 or 0, the digit is ignored.
//7.	Step 1 is repeated for the newly generated cages with bunnies.
//Here is an example for better clarification:
//•	Consider we have 12 cages with these bunnies: 3 2 5 5 4 8 4 9 5 6 3 4.
//•	The factory starts the process with the first cycle, so it takes the first cage as sum s – 3. 
//•	The factory takes the next 3 cages (2 5 5) after the first one and calculates their sum – 12 – and product – 50. 
//•	The factory concatenates the results and appends all the untouched cages – 12, 50 and 48495634 – resulting in 125048495634. 
//•	All digits equal to 1 or 0 are excluded – final result is 2548495634.
//•	The factory fills the next cages with bunnies – 2 5 4 8 4 9 5 6 3 4.
//•	The factory continues with the second cycle(repeating), so it takes the first two cages and calculates their sum s – 2 + 5 – 7.
//•	The factory takes the next 7 cages(4 8 4 9 5 6 3) after second one and calculates their sum – 39 – and product – 103680.
//•	The factory concatenates the results and appends all the untouched cages – 39, 103680 and 4 – resulting in 391036804.
//•	All digits equal to 1 or 0 are excluded – final result is 393684.
//•	The factory fills the next cages with bunnies – 3 9 3 6 8 4. 
//•	The factory continues with the third cycle(repeating), so it takes the first three cages and calculates their sum – 15.
//•	There are no 15 cages after the third one, so the multiplication process stops.
//•	The final cages are filled with these bunnies – 3 9 3 6 8 4.
//Input
//The input data consists of N + 1 lines – the first N lines will be the N initial cages filled with bunnies and the last line will always be "END" indicating the end of the input.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the amount of bunnies in each cage after the multiplication process, separated by a single space character (" ").
//Constraints
//•	N will be between 1 and 100.
//•	Bunnies in every cage will be between 1 and 100.
//•	Some of the calculations during the multiplication process will have more than 20 digits.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input:
//3
//2
//5
//5
//4
//8
//4
//9
//5
//6
//3
//4
//END	
//Output: 3 9 3 6 8 4


namespace _02.BunnyFactory
{
   using System;
   using System.Collections.Generic;  //for new List<int>();
   using System.Linq; //for cages.Select(x => x.ToString()).ToArray()
   using System.Numerics;


   class BunnyFactory
   {
      static void Main()
      {
         string currentCage = Console.ReadLine();

         //List<T> Solution
         //List<int> cages = new List<int>(); //replace 'n' with cages.Count

         //Array Solution
         int[] cages = new int[205]; //the number could be with 200 digits. Put it on 205 just in case
         int n = 0;

         while (currentCage != "END")
         {
            //cages.Add(int.Parse(currentCage);

            cages[n] = int.Parse(currentCage);
            n++;

            currentCage = Console.ReadLine();
         }

         for (int i = 1; i < n; i++) //check if it's correct //Step 1 is i < n
         {
           //Step 2
            int s = 0;
            for (int j = 0; j < i; j++)
            {
               s += cages[j]; //sum is calculated
            }

            //Step 3
            if (n - i < s)
            {
               break;
            }

            //Step 4
            int sum = 0;
            BigInteger product = 1; 
            for (int j = i; j < i + s; j++)
            {
               sum += cages[j];
               product *= cages[j];
            }

            //Step 5
            string next = sum.ToString() + product.ToString();

            for (int j = i + s; j < n; j++)
            {
               next += cages[j].ToString();
            }

            //Step 6
            next = next.Replace("0", "");
            next = next.Replace("1", "");


            n = next.Length;
            for (int j = 0; j < n; j++)
            {
               cages[j] = next[j] - '0';
            }

            
         }
        
         Console.WriteLine(string.Join(" ", cages.Select(x => x.ToString()).ToArray(), 0, n));



      }
   }
}
