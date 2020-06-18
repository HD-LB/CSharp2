using System;
using System.Text;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

//Input
//•On the only input line you will receive a string

//Output
//•Print the string without consecutive identical letters

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  aaaaabbbbbcdddeeeedssaa

//Output:  abcdedsa



namespace _23.SeriesOfLetters
{
   class SeriesOfLetters
   {
      static void Main(string[] args)
      {
         string text = Console.ReadLine();
         StringBuilder output = new StringBuilder();

         output.Append(text[0]);
         for (int i = 1; i < text.Length; i++)
         {
            if (text[i] != text[i - 1])
            {
               output.Append(text[i]);
            }
         }
         Console.WriteLine(output.ToString());
       
      }
   }
}
