//•You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Linq;

namespace _05.SortByStringLenght
{
   class SortByStringLenght
   {
      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         string[] strings = new string[n];
         for (int i = 0; i < strings.Length; i++)
         {
            Console.Write("{0}, ", strings);
            strings[i] = Console.ReadLine();
         }

         //string[] stringArrays = Console.ReadLine().Split(' ').ToArray();
         //var sorted = stringArrays.OrderBy(x => x);
         //foreach (var stringArray in sorted)
         //{
         //   Console.WriteLine(stringArray);
         //}

         Array.Sort(strings, (x, y) => (x.Length).CompareTo(y.Length)); //ascending order
         
         foreach (string item in strings)
         {
            Console.WriteLine(item);
         }

         Array.Sort(strings, (x, y) => (y.Length).CompareTo(x.Length)); //descending order
         foreach (string item in strings)
         {
            Console.WriteLine(item);
         }
      }
   }
}
