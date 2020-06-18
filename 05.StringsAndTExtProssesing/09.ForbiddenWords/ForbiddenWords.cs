using System;
using System.Text.RegularExpressions;

//We are given a string containing a list of forbidden words and a text containing some of these words.Write a program that replaces the forbidden words with asterisks.

//Sample tests


//Input: Microsoft announced its next generation PHP compiler today.It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//PHP CLR Microsoft 


//Output: ********* announced its next generation*** compiler today.It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***. 


namespace _09.ForbiddenWords
{
   class ForbiddenWords
   {
      static void Main()
      {
         string text = "Microsoft announced its next generation PHP compiler today.It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
         string[] words = "PHP CLR Microsoft".Split(' ');

         Console.WriteLine(ReplacedWords(text, words));


         //string forbiddenWords = @"(\b(PHP|CLR|Microsoft\b)";
         //Console.WriteLine(Regex.Replace(text,forbiddenWords, m => new String( '*', m.Length)));
      }

      private static string ReplacedWords(string text, string[] words)
      {
         foreach (var word in words)
         {
            text = text.Replace(word, new string('*', word.Length));
         }
         return text;
      }

   }
}
