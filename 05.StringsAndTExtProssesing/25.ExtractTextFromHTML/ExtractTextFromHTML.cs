using System;
using System.Text.RegularExpressions;

//Write a program that extracts from given HTML file its title(if available), and its body text without the HTML tags.

//Example input:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href = "http://academy.telerik.com" > Telerik

//  Academy</a> aims to provide free real-world practical

//  training for young people who want to turn into
//  skilful .NET software engineers.</p></body>
//</html>



//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.


namespace _25.ExtractTextFromHTML
{
   class ExtractTextFromHTML
   {
      static void Main()
      {
         string htmlText = Console.ReadLine();
         MatchCollection output = Regex.Matches(htmlText, "(?<=^|>)[^><]+?(?=<|$)");
         foreach (var item in output)
         {
            Console.WriteLine(item);
         }
      }
   }
}
