using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.

//Input
//•On the only input line you will receive a string

//Output
//•Print the string in C# Unicode character literals on a single line

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  Hi!

//Output: \u0048\u0069\u0021 


namespace _10.UnicodeCharacters
{
   class UnicodeCharacters
   {
      
      static void Main()
      {

         string text = Console.ReadLine();
         Console.WriteLine(ConvertToUnicode(text));
      }


      private static string ConvertToUnicode(string text)
      {
         StringBuilder sb = new StringBuilder();
         for (int i = 0; i < text.Length; i++)
         {
            sb.AppendFormat("\\u{0:X4}", (int)text[i]);
         }
         return sb.ToString();
      }

   }
}
