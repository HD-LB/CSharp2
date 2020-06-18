using System;
using System.Linq;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24.OrderWords
{
   class OrderWords
   {
      static void Main(string[] args)
      {
         string words = Console.ReadLine();
         string[] wordsArr = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         //1.Way
         Array.Sort(wordsArr);
         foreach (var word in wordsArr)
         {
            Console.WriteLine(word);

         }

         //2.Way 
         var sortedWords = wordsArr.OrderBy(x => x); //Alphabetical order sort
         foreach (var word in sortedWords)
         {
            Console.WriteLine(word);
         }
         
      }
   }
}
