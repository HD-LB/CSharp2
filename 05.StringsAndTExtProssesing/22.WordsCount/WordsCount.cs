using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

namespace _22.WordsCount
{
   class WordsCount
   {
      static void Main(string[] args)
      {
         string text = @"Sofia is the capital and largest city of Bulgaria. The city is located at the foot of Vitosha Mountain 
                         in the western part of the country. It occupies a strategic position at the centre of the BalkanPeninsula. 
                         Sofia is the 15th largest city in the European Union with population of around 1.3 million people.  
                         Many of the major universities, cultural institutions and commercial companies of Bulgaria are concentrated in Sofia.";
                  
         string[] textArr = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);


         Dictionary<string, int> dictionary = new Dictionary<string, int>();
         foreach (var word in textArr)
         {
            if (dictionary.ContainsKey(word))
            {
               dictionary[word]++;
            }
            else
            {
               dictionary.Add(word, 1);
            }
         }
         foreach (var word in dictionary)
         {
            Console.WriteLine("{0} - {1}", word, word.Value);
         }
                  
      }
   }
}
