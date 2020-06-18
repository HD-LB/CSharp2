using System;
using System.Collections.Generic; //for List<T>
using System.Linq;//for .Any

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).
//•If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100

//Input
//•You will receive 10 lines of input, each consisted of an integer number ◦a1
//◦a2
//◦...
//◦a10


//Output
//•Print 1 < a1< ... < a10< 100 ◦Or Exception if the above inequality is not true


//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: //5
//7
//15
//29
//46
//47
//60
//70
//89
//98 

//Output:  1 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100 



//Input: //87
//10
//29
//28
//43
//58
//95
//41
//2
//46 


//Output: Exception 

//Input: 5
//11
//20
//27
//49
//41
//52
//81
//89
//99 

//Output: Exception


namespace _02.EnterNumbers
{
   class EnterNumbers
   {
      static int start = 0;
      static int end = 100;
      static int count = 10;
        
     
      static void Main(string[] args)
      {
         List<int> numbers = new List<int>();
         for (int i = 0; i < count; i++)
         {
            numbers.Add(int.Parse(Console.ReadLine()));
         }
         try
         {
            if (numbers.Any(x => x < start) || numbers.Any(x => x > end) || !IsInscreasing(numbers))
            {
               throw new ArgumentException();
            }
            Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
         }
         catch (Exception)
         {

            Console.WriteLine("Exception");
         }
      }

      private static bool IsInscreasing(List<int> numbers)
      {
         for (int i = 1; i < numbers.Count; i++) //.Count, because it's a List<T>
         {
            if (numbers[i- 1].CompareTo(numbers[i]) >= 0)
            {
               return false;
            }
         }
         return true;
      }
   }
}
