using System;
using System.Globalization;

//•Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days


namespace _16.DateDifference
{
   class DateDifference
   {
      static void Main()
      {
         Console.Write("Enter the first Date: ");
         string firstDate = Console.ReadLine();
         Console.Write("Enter the second Date: ");
         string secondDate = Console.ReadLine();

         DateTime first = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
         DateTime second = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);

         Console.WriteLine("Distance: {0} days", Math.Abs((first - second).TotalDays));

         
      }
   }
}
