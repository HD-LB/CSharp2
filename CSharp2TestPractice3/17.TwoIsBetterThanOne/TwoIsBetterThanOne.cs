//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/54/CSharp-Part-2-2012-2013-5-Feb-2013

//Solving one task is too mainstream.You are given two tasks. Solve them both.
//First task
//The digits 3 and 5 are lucky digits, and all other digits are unlucky. A lucky number is a positive integer whose decimal representation is a palindrome that contains only lucky digits.A palindrome is a number that reads the same forward and backward.Write a program that counts the number of lucky numbers within a specified range.
//You are given two integers A and B. Return the number of lucky numbers between A and B, inclusive.
//Second task
//Given a list of integer and a percentile P (integer between 0 and 100, inclusive), find the smallest element E in the list such that at least P percent of the elements in the list are less than or equal to E.
//Input
//The input data should be read from the console.
//The number A and number B will be given on the first input line, separated by a single space.
//On the second input line there will be the list of numbers mentioned in the second task.The numbers in the list will be separated by commas.On the third output line there will be the number P.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the first output line print the solution of the first task (the number of lucky numbers).
//On the second output line print the solution of the second task(the element found).
//Constraints
//•	A will be between 1 and 10^18, inclusive.B will be between A and 10^18, inclusive.
//•	The number of the elements in the list from second task will be between 1 and 50, inclusive.
//•	Each element in the list from the second task will be between -1000000 and 1000000, inclusive.
//•	Allowed working time for your program: 0.2 seconds.Allowed memory: 16 MB.
//Examples
//Example input   Example output
//1 99
//-2,-1,-4,-3
//50	               4
//                  -3

//Example input                  Example output
//35 53
//10,9,8,7,6,5,4,3,2,1
//39	                              0
//                                  4





namespace _17.TwoIsBetterThanOne
{
   using System;
   using System.Collections.Generic;
 

   class TwoIsBetterThanOne
   {
      static bool IsPalindrom(long number)
      {
         string num = number.ToString();
         for (int i = 0; i < num.Length / 2; i++)
         {
            if (num[i] != num[num.Length - i - 1])
            {
               return false;
            }
         }

         return true;
      }

      static int FindLucyNumbers(long lowerBound, long upperBound)
      {
         long max = upperBound; // (long)Math.Pow(10, 18); //1000000000000000000;
         int left = 0;
         var numbers = new List<long> { 3, 5 };
         int count = 0;

         while (left < numbers.Count)
         {
            int right = numbers.Count;

            for (int i = left; i < right; i++)
            {
               if (numbers[i] < max)
               {
                  numbers.Add((numbers[i] * 10) + 3);
                  numbers.Add((numbers[i] * 10) + 5);
               }
            }
            left = right;

         }

         foreach (var num in numbers)
         {
            if (num >= lowerBound && num <= upperBound && IsPalindrom(num))
            {
               count++;
            }
         }

         return count;
      }


      static void Main()
      {
         string input = Console.ReadLine();
         string[] tokens = input.Split(' ');

         long lowerBound = long.Parse(tokens[0]);
         long upperBound = long.Parse(tokens[1]);

         int count = FindLucyNumbers(lowerBound, upperBound);
         Console.WriteLine(count); //first Answer 

         string inputList = Console.ReadLine();
         string[] listTokens = inputList.Split(',');
         List<int> numbers = new List<int>();

         //Filling the List
         for (int i = 0; i < listTokens.Length; i++)
         {
            numbers.Add(int.Parse(listTokens[i]));
         }

         int persent = int.Parse(Console.ReadLine()); // as per Instructions

         int answerSecondTask = FindAnswerSecondTask(numbers, persent);

         Console.WriteLine(answerSecondTask); //secondAnswer

      }

      private static int FindAnswerSecondTask(List<int> numbers, int persent)
      {
         numbers.Sort();

         for (int i = 0; i < numbers.Count; i++)
         {
            int countSmaller = 0;

            for (int j = 0; j < numbers.Count; j++)
            {
               if (numbers[i] >= numbers[j])
               {
                  countSmaller++;
               }
            }

            if (countSmaller >= (numbers.Count * (persent / 100.0)))
            {
               return numbers[i];
            }
         }

         return numbers[numbers.Count - 1];
      }
   }
}


