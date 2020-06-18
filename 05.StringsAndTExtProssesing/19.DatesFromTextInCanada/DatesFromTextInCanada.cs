using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.Display them in the standard date format for Canada.


namespace _19.DatesFromTextInCanada
{
   class DatesFromTextInCanada
   {
      static void Main(string[] args)
      {
         string text = @"I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";

         string[] textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         for (int i = 0; i < textArr.Length; i++)
         {
            if (Regex.IsMatch(textArr[i], @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
            {
               Console.WriteLine(textArr[i]);
            }
         }

      }
   }
}
