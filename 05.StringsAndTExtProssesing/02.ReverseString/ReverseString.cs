using System;
using System.Text;

//Reverse string

//Description
//•Write a program that reads a string, reverses it and prints the result on the console.

//Input
//•On the only line you will receive a string

//Output
//•Print the string in reverse on a single line

//Constraints
//•1 <= size of string <= 10000
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: sample         somestring

//Output:  elpmas       gnirtsemos


namespace _02.ReverseString
{
   class ReverseString
   {
      static void Main()
      {
         string text = Console.ReadLine();


         for (int i = text.Length - 1; i >= 0; i--)
         {
            Console.WriteLine(text[i]);
         }
         Console.WriteLine();

         //
         char[] textAsChar = text.ToCharArray();
         Array.Reverse(textAsChar);
         text = string.Join("", textAsChar);
         Console.WriteLine(text);

         //
         StringBuilder reversedText = new StringBuilder();
         for (int i = 0; i < text.Length; i++)
         {
            reversedText.Insert(0, text[i]);
         }
         Console.WriteLine(reversedText.ToString());
      }
     
   }
}
