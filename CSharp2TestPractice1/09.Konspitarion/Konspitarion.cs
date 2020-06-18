//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://bgcoder.com/Contests/221/CSharp-Part-2-2015-2016-5-March-2015-Evening


//Your task is simple.Just pet the cat a bit and you are done. Actually, you need to solve one hard programming problem in addition to petting Котангенс. 
//You are given a C# code with valid syntax. Your task is to find where all method invokes happen. For each declared method, you need to find all invoked methods in it. See the example below for better clarification.
//For your convenience (and because the cat is cute) the C# code have some limitations to make the task easier.
//•	The code will be fully understandable by you for your current level at C# Part 2. There will be no strange structures, object oriented programming, cats lurking around the text, unknown keywords, konspirations, whatsoever… 
//•	All method declarations will be static without any access modifiers.Access modifiers are “public”, “private”, “internal” and “protected”.
//•	The code will not be necessary compiling but will be with valid C# syntax.
//•	All curly brackets will be formatted and put on correct separate lines.
//•	All method names will be on the same line with the static keyword.
//•	There will not be any other static declarations except for the methods.
//•	There will not be any commented code or code in strings.
//•	The code will be easily readable. There will not be any unnecessary line breaks and empty new lines.Unnecessary spaces may occur here and there though(Котангенс is playful).
//•	Brackets are your best friends. ;)
//You will be given N lines with C code.Find all method invokes in which particular method declaration are called.Order the method invokes in the order they are called in code.Print them in the following format: “{ method declaration} -> {number of calls} -> {method1 call, method2 call, method 3 call}”. If there are no method calls in certain declaration, print “{method declaration} -> None”. See the example below.
//Mrrr(no konspirations around the cat though…)
//Input
//The input data should be read from the console.
//On the first input line you will be given the number N.
//On the next N lines you will read the C# code.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//For each method declaration print separate line, in which you show all invokes in format described above.
//Constraints
//•	N will be between 10 and 200, inclusive.
//•	Each line will have at most 1 000 characters.
//•	The code will follow the rules described above.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.


namespace _09.Konspitarion
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
  

   class Konspitarion
   {
      //all Methods will start with "static" keyword
      //all Mathods will have (...) on the same line
      //all Methods will have {....} on the nexe line
      //all Methods Calls and Names start with capital Letters
      //get Method Bodies be splitting by "static" or by counting brackets
      //need to handle the "new" keyword



      static string ExtractMethodName(string codePiece)
      {
         var beforeBracket = codePiece.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

         var methodName = beforeBracket[beforeBracket.Length - 1];
         if (char.IsUpper(methodName[0]) && !beforeBracket.Contains("new")) //if the first symbol is a capital Letter
         {
            return methodName;
         }
         return null;
      }


      
      static void Main(string[] args)
      {
         var n = int.Parse(Console.ReadLine());

         var lines = new string[n];
         for (int i = 0; i < n; i++)
         {
            lines[i] = Console.ReadLine();
         }
         // var lines2 = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToArray();

         for (int i = 0; i < n; i++)
         {
            if (lines[i].Contains(" static"))
            {
               var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];

               i += 2;

               var openBrackets = 1;
               var methodCalls = new List<string>();

               while (openBrackets > 0)
               {
                  var splitByRoundBracket = lines[i].Split('(');

                
                  if (splitByRoundBracket.Length > 1)
                  {
                     for (int k = 0; k < splitByRoundBracket.Length - 1; k++)
                     {
                        var methodName = ExtractMethodName(splitByRoundBracket[0]);
                        if (methodName != null)
                        {
                           methodCalls.Add(methodName);
                        }
                     }
                  }



                  foreach (var symbol in lines[i])
                  {
                     if (symbol == '{')
                     {
                        openBrackets++;
                     }
                     else if (symbol == '}')
                     {
                        openBrackets--;
                     }
                  }

                  i++;
               }
               if (methodCalls.Count > 0)
               {
                  Console.WriteLine(name + " -> " + methodCalls.Count + " -> " + string.Join(", ", methodCalls));
               }
               else
               {
                  Console.WriteLine(name + " -> None");
               }
               

            }
         }
      }
   }
}
