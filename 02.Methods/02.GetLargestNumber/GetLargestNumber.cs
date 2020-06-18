using System;

//Description

//Write a method GetMax() with two parameters that returns the larger of two integers.Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

//Input
//•On the first line you will receive 3 integers separated by spaces

//Output
//•Print the largest of them

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input

//Output


//8 3 6 8 
//7 19 19 19 


namespace _02.GetLargestNumber
{
   class Program
   {

      static int GetMax(int a, int b)
      {
         if (a > b)
         {
            return a;
         }
         else
         {
            return b;
         }
      }
      static void Main()
      {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         int c = int.Parse(Console.ReadLine());

         Console.WriteLine("The largest number is: {0}", GetMax(GetMax(a, b), c));
      }
   }
}
