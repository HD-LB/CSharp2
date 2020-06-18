using System;
//Write a program that reads a year from the console and checks whether it is a leap one.

//Hint: Use System.DateTime.

//Input
//•On the only line you will receive a number - the year

//Output
//•Print "Leap" or "Common" on a single line depending on the year

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: //2016
         //1996
         //1900
         //2000
         //681
         //3400

//Output: //Leap   
         //Leap
         //Common
         // Leap
         //Common
         // Common


namespace LeapYear
{
   class LeapYear
   {
      static void Main()
      {
         int year = int.Parse(Console.ReadLine());

         var leapYear = DateTime.IsLeapYear(year) ? "Leap" : "Common";

         Console.WriteLine(leapYear);
      }
   }
}
