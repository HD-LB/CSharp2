using System;

//Description

//Write a method that returns the last digit of given integer as an English word.Write a program that reads a number and prints the result of the method.

//Input
//•On the first line you will receive a number

//Output
//•Print the last digit of the number as an English word

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input


//Output


//42 two


namespace _03.EnglishDigit
{
   class Program
   {
      static string DigitAsWord(int number)
      {
         string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
         number %= 10;
         return words[number];

      }
      static void Main()
      {
         int number = int.Parse(Console.ReadLine());
         Console.WriteLine("{0}", DigitAsWord(number));

      }
   }
}
