using System;

//Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).

//Input
//•On the first line you will receive a string - the pattern
//•On the second line you will receive a string - the text

//Output
//•Print a number on a single line ◦The number of occurrences


//Constraints
//•The length of the two strings will be <= 4096
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  in
//        We are living in an yellow submarine.We don't have anything else. inside the submarine is very tight. So we are                drinking all the day. We will move out of it in 5 days.

//Output: 9



namespace _04.SubstringInText
{
   class SubstringInText
   {
      static void Main()
      {
         string str = Console.ReadLine().ToLower();
         string text = Console.ReadLine().ToLower();

         int strCounter = 0;
         int index = 0;
         while (true)
         {
            int found = text.IndexOf(str, index);
            if (found < 0)
            {
               break;
            }
            strCounter++;
            index = found + 1;
         }
         Console.WriteLine(strCounter);
         
      }
   }
}
