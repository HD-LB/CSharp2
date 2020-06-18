using System;
using System.Collections;
using System.Collections.Generic;

//A dictionary is stored as a sequence of text lines containing words and their explanations.Write a program that enters a word and translates it by using the dictionary.

//Sample tests


//Input:  .NET
//         CLR
//         namespace


//Output:   platform for applications from Microsoft
//          managed execution environment for .NET
//          hierarchical organization of classes


namespace _14.WordDictionary
{
   class WordDictionary
   {
      static void Main(string[] args)
      {
         
         var dictionary = new Dictionary<string, string>()
           {
                { ".NET", "platform for applications from Microsoft" },
                { "CLR", "managed execution environment for .NET" },
                { "namespace", "hierarchical organization of classes" }
            };

         var input = Console.ReadLine();
         Console.WriteLine(dictionary[input]);

      }
   }
}
