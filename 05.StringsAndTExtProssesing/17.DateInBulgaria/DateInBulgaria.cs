using System;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes(in the same format) along with the day of week in Bulgarian.

namespace _17.DateInBulgaria
{
   class DateInBulgaria
   {
      static void Main(string[] args)
      {
         Console.Write("Input date: ");
         string inputDate = Console.ReadLine();

         DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
         date = date.AddHours(6.5);

         Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
              

      }
   }
}
