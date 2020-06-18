using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

namespace _21.LettersCount
{
   class LettersCount
   {
      static void Main(string[] args)
      {
         //string text = Console.ReadLine();

         string text = @"Sofia is the capital and largest city of Bulgaria. The city is located at the foot of Vitosha Mountain 
                         in the western part of the country. It occupies a strategic position at the centre of the BalkanPeninsula. 
                         Sofia is the 15th largest city in the European Union with population of around 1.3 million people.  
                         Many of the major universities, cultural institutions and commercial companies of Bulgaria are concentrated in Sofia.";

         Dictionary<char, int> dictionary = new Dictionary<char, int>();
         for (int i = 0; i < text.Length; i++)
         {
            if (dictionary.ContainsKey(text[i]))
            {
               dictionary[text[i]]++;
            }
            else
            {
               dictionary.Add(text[i], 1);
            }
         }
         foreach (var letter in dictionary.OrderByDescending(m => m.Value))
         {
            Console.WriteLine("{0} - {1}", letter.Key, letter.Value);
         }
      }
   }
}
