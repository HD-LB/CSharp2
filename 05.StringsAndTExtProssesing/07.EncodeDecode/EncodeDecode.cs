using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key(cipher).
//•The key consists of a sequence of characters.
//•The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.When the last key character is reached, the next is the first.

namespace _07.EncodeDecode
{
   class EncodeDecode
   {
      //static string EncodeAndDecode(string text, string key)
      //{
      //   StringBuilder result = new StringBuilder();
      //   for (int i = 0; i < text.Length; i++)
      //   {
      //      //get the next character from the text
      //      char character = text[i];

      //      //cast it to int
      //      int charCode = (int)character;

      //      //find which character to take from the key
      //      int keyPosition = i % key.Length;

      //      //take the key character
      //      int keyChar = key[keyPosition];

      //      //also cast it to int
      //      int keyCode = (int)keyChar;

      //      //perform ^ (XOR) 
      //      int combinedCode = charCode ^ keyCode;

      //      result.Append(combinedCode);
      //   }
      //   return result.ToString();
      //}
      //static void Main()
      //{
      //   string text = Console.ReadLine();
      //   string key = Console.ReadLine();

      //   Console.WriteLine("Encripted text: ");
      //   Console.WriteLine(EncodeAndDecode(text, key));
      //   Console.WriteLine("Decripted text: ");
      //   Console.WriteLine(EncodeAndDecode(EncodeAndDecode(text, key), key));
         
      //}



      private static string EncodeAndDecode(string text, string key)
      {
         StringBuilder encodedText = new StringBuilder();
         int currentTextLetter = 0;
         int currentKeyLetter = 0;

         for (int i = 0; i < text.Length; i++)
         {
            currentTextLetter = (int)text[i];
            currentKeyLetter = (int)key[i % key.Length];
            encodedText.Append((char)(currentTextLetter ^ currentKeyLetter));
         }
         return encodedText.ToString();
      }
      static void Main()
      {
         string text = Console.ReadLine();
         string key = Console.ReadLine();
         string encoded = EncodeAndDecode(text, key);
         string decoded = EncodeAndDecode(encoded, key);
         Console.WriteLine(encoded);
         Console.WriteLine(decoded);
      }
   }
}
