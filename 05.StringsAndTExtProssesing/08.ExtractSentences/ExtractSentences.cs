using System;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.

//Input
//•On the first line you will receive a string - the word
//•On the second line you will receive a string - the text

//Output
//•Print only the sentences containing the word on a single line

//Constraints
//•Sentences are separated by . and the words – by non-letter symbols
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  in
//        We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are                 drinking all the day. We will move out of it in 5 days.

//Output:  We are living in a yellow submarine. We will move out of it in 5 days. 


namespace _08.ExtractSentences
{
   class ExtractSentences
   {
      static void Main()
      {
         string word = Console.ReadLine();
         string text = Console.ReadLine();
         
         string[] sentanceArr = text.Split('.'); //separates each sentance
         for (int i = 0; i < sentanceArr.Length; i++)
         {
            if (Regex.IsMatch(sentanceArr[i], @"\b" + word + @"\b", RegexOptions.IgnoreCase))
            {
               Console.WriteLine((sentanceArr[i] + ".").Trim());
            }
         }

      }
   }
}
