using System;

//Description

//Write a method that counts how many times given number appears in a given array.Write a test program to check if the method is working correctly.

//Input
//•On the first line you will receive a number N - the size of the array
//•On the second line you will receive N numbers separated by spaces - the numbers in the array
//•On the third line you will receive a number X


//Output
//•Print how many times the number X appears in the array


//Constraints
//•1 <= N <= 1024
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input


//Output


//8
//28 6 21 6 -7856 73 73 -56
//73 2 


namespace _04.AppearanceCount
{
   class AppearanceCount
   {
      static int Array(int[] arr, int searchedNumber)
      {
         int counter = 0;
         for (int i = 0; i < arr.Length; i++)
         {
            if (arr[i] == searchedNumber)
            {
               counter++;
            }

         }
         return counter;
      }
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         int[] arr = new int[n];
         //Filling the Array
         for (int i = 0; i < n; i++)
         {
            Console.Write("Array[{0}]: ", i);
            arr[i] = int.Parse(Console.ReadLine());
         }

         int searchedNumber = int.Parse(Console.ReadLine());

         Array(arr, searchedNumber);
         Console.WriteLine("The number {0} appears {1} in the array.", searchedNumber, Array(arr, searchedNumber));
      }
      
   }
}

