using System;
using System.Text;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace _20.Palindromes
{
   class Palindromes
   {
      static void Main(string[] args)
      {
         string text = @"The most familiar palindromes, in English at least,  
                         are character-by-character: The written characters read the same  
                         backward as forward. Some examples of common palindromic words: civic, 
                         radar, level, rotor, kayak, reviver, racecar, redder, madam, malayalam,  
                         and refer.";

         

         text = text.ToLower();

         string[] textArr = text.Split(new char[] { ' ', ',', '.', ':', '!' }, StringSplitOptions.RemoveEmptyEntries);

         StringBuilder output = new StringBuilder();


         foreach (string word in textArr)
         {
            bool isPolindrom = true;
            for (int i = 0; i < (word.Length / 2); i++)
            {
               if (word[i] != word[word.Length - 1 - i])
               {
                  isPolindrom = false;
                  break;
               }
            }
            if (isPolindrom)
            {
               output.Append(word + " ");
            }
         }
         Console.WriteLine("{0}", output);

         //string regex = @"\b\w+\b";

      }
   }
}
