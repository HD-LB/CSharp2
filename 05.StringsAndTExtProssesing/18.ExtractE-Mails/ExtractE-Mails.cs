using System;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.All sub-strings that match the format<identifier>@<host>…<domain> should be recognized as emails.
namespace _18.ExtractE_Mails
{
   class Program
   {
      static void Main()
      {
         string text = @"Please contact us by phone (+359 222 222 222) or by email at exa_mple@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";

         string[] textArr = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         for (int i = 0; i < textArr.Length; i++)
         {
            if (Regex.IsMatch(textArr[i], @"[\w.]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}")) //Every word from 2 to 20 charecters, digits or underscore, followd by @, followd by words from 2 to 20 charecters, digits or underscore, followd by Single Dot '.', followd by words from 2 to 6 charecters, digits or dot
            {
               Console.WriteLine(textArr[i]);
            }
         }
      }
   }
}
