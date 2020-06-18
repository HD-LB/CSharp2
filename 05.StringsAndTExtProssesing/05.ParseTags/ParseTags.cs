using System;
using System.Text.RegularExpressions;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags<upcase> and</upcase> to upper-case.


//Input
//•On the only line you will receive a string - the text


//Output
//•Print the changed string on one line


//Constraints
//•The tags will not be nested.
//•String length will be <= 10000
//•Time limit: 0.1s
//•Memory limit: 16MB

//Input:  We are living in a<upcase> yellow submarine</upcase>.We don't have <upcase>anything</upcase> else. 


//Output:  We are living in a YELLOW SUBMARINE. We don't have ANYTHING else. 


namespace _05.ParseTags
{
   class ParseTags
   {
      static void Main()
      {
         string text = Console.ReadLine();

         string toUpper = Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper());
         Console.WriteLine(toUpper);
                  
      }
   }
}
