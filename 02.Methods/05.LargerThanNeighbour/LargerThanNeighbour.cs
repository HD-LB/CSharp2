using System;

//Description

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours(when such exist). Write program that reads an array of numbers and prints how many of them are larger than their neighbours.

//Input
//•On the first line you will receive the number N - the size of the array
//•On the second line you will receive N numbers separated by spaces - the array

//Output
//•Print how many numbers in the array are larger than their neighbours

//Constraints
//•1 <= N <= 1024
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input

//Output


//6
//-26 -25 -28 31 2 27 2 


namespace _05.LargerThanNeighbour
{
   class LargerThanNeighbour
   {
      static void CheckNeighbours(int n, int[] array, int position)
      {
         if (position == 0 || position == array.Length - 1)
         {
            Console.WriteLine("Number {0} on index {1} has only one neighbour.", array[position], position);
         }
         else if (array[position] > array[position - 1] && array[position] > array[position + 1])
         {
            Console.WriteLine("Number {0} on index {1} is biggert that its two neighbours.", array[position], position);
         }
         else if (array[position] < array[position - 1] || array[position] < array[position + 1])
         {
            Console.WriteLine("Number {0} on index {1} is smaller than at least one of its two neighbours.", array[position], position);
         }
         else
         {
            Console.WriteLine("Number {0} on index {1} is equal to its two neighbours.", array[position], position);
         }

      }
      static void Main()
      {
         //Array
         int n = int.Parse(Console.ReadLine());
         int[] array = new int[n];
         for (int i = 0; i < array.Length; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
         }

         //Position
         int position = int.Parse(Console.ReadLine());

         CheckNeighbours(n, array, position);
      }
   }
}
