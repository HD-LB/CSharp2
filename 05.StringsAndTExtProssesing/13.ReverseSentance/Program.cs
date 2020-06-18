using System;
using System.Text;
//Write a program that reverses the words in a given sentence.

//Sample tests


//Input: C# is not C++, not PHP and not Delphi!

//Output: Delphi not and PHP, not C++ not is C#! 


namespace _13.ReverseSentance
{
   class Program
   {
      static void Main(string[] args)
      {
         string sentance = Console.ReadLine();
         string reversed = ReversedSentance(sentance);

         Console.WriteLine(reversed);
      }

      private static string ReversedSentance(string sentance)
      {
         StringBuilder reversed = new StringBuilder();
         string[] words = sentance.Split(new string[] { "!", ".", " ", ",", ", " }, StringSplitOptions.RemoveEmptyEntries);
         for (int i = words.Length - 1; i >= 0; i--)
         {
            reversed.Append(words[i] + " ");
         }
         return reversed.ToString();
      }
   }
}
