using System;
using System.Linq;

//Description

//Write a method that returns the maximal element in a portion of array of integers starting at given index.Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

//Input
//•On the first line you will receive the number N - the size of the array
//•On the second line you will receive N numbers separated by spaces - the array

//Output
//•Print the sorted array ◦Elements must be separated by spaces


//Constraints
//•1 <= N <= 1024
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:   6                       10 
//         3 4 1 5 2 6             36 10 1 34 28 38 31 27 30 20


//Output:  1 2 3 4 5 6             1 10 20 27 28 30 31 34 36 38 



namespace _09.SortingArray
{
   class Program
   {
      static int[] ConvertToArray(string number)
      {
         int[] num = number.Split(' ').Select(int.Parse).ToArray();
         return num;
      }


      static void Main()
      {
         var lenght = int.Parse(Console.ReadLine());
         var arr = ConvertToArray(Console.ReadLine());

         Array.Sort(arr);
         Console.WriteLine(string.Join(" ",arr));
      }
   }
}
