//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/54/CSharp-Part-2-2012-2013-5-Feb-2013

//As you may or may not know, Joro got drunk last Friday and deleted his Visual Studio’s IntelliSense.Now, he has to work without one, but he doesn’t like the idea. The worst thing is he can’t work properly without the feature, which formats his code – more specifically, he needs his opening and closing brackets to be properly aligned, and the text between them to be properly indented.
//Here are some bullets on how Joro wants his code to be formatted:
//1.	The brackets Joro needs to be considered in the formatting are { and } – i.e.the ones defining bodies of loops, conditionals, methods, etc.
//2.	Joro doesn’t use tabulations to indent his code, he uses some specific string, for example /*--*/
//o  Joro will tell you the string each time he needs to format something
//3.	Each bracket needs to be on a separate line, with the proper indentation(or lack thereof)
//4.	The code within an opening and closing bracket must be indented with one more indentation string than the brackets themselves
//5.	There must be no empty lines in the formatted code
//6.	There must be no whitespaces at the beginning or end of the lines
//7.	There must be no empty spaces at the beginning or end of a formatted line, except if they are part of the indentation string
//o  Also, there must be no whitespaces between the line itself and the indentation string
//8.	There must be no sequences of empty spaces, with a length of more than 1
//o That is, there can be single spaces between symbols in the code, but not two or more consecutive spaces
//Write a program, which formats code, according to the rules described
//Input
//The input data should be read from the console.
//On the first line of the input there will be the number N – the total number of lines in Joro’s initial code.
//On the next line of the input there will be a string S – the indentation string, which can consist of any symbols.
//Each of the next N lines will contain a line of Joro’s code. The code will be of the C# syntax, but it is not guaranteed to be valid. The brackets, however, will be valid.
// The input data will always be in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print all lines of the formatted code.
//Constraints
//•	0 < N< 1000
//•	0 < S.Length< 100
//•	S will not have leading or trailing whitespaces (S.Trim() will be equal to S)
//•	There could be empty lines in the input
//•	There could be sequences of whitespaces in the input
//•	The brackets will always be valid, but the code inside could have mistakes
//•	There will be no other { and } than the ones defining loop, method or conditional statement bodies – that means there will be no { or } in strings, comments, etc.
//•	Do not try to make "perfect C# formatting" – only what is required by the aforementioned rules 
//•	Allowed working time for your program: 0.15 seconds.Allowed memory: 16 MB.
//Examples
//Input example         Output example
//3
//>>
//{a{
//}
//}	                  {
//                      >>a
//                      >>{
//                      >>}
//                      }



//5
//....
//using System;    namespace Stars
//{
//   class Program
//   {
//      static string[] separators
//      = new string[] { " " };
//   }
//}
//	                                          using System; namespace Stars
//                                           {
//                                           ....class Program
//                                           ....{
//                                           ........static string[] separators
//                                           ........= new string[]
//                                           ........{
//                                           ............" "
//                                           ........}
//                                           ........;
//                                           ....}
//                                           }

//Note: The second example contains a single whitespace after the word "separators" on the third line of the code



namespace _07.Brackets
{
   using System;
   using System.Text;

   class Brackets
   {
      static StringBuilder sb = new StringBuilder();
      static string tabs;
      static int tabsCount = 0;
      static bool shouldPrintNewLine = false;
      static bool isFirstSymbol = true;
      private static object l;

      static void Main()
      {
         int n = int.Parse(Console.ReadLine());
         tabs = Console.ReadLine();

         for (int i = 0; i < n; i++)
         {
            string line = Console.ReadLine().Trim();

            HandleLine(line);
         }

         Console.WriteLine(sb);


      }

      private static void HandleLine(string line = "")
      {
         for (int i = 0; i < line.Length; i++)
         {
            if (shouldPrintNewLine)
            {

               sb.AppendLine();
               shouldPrintNewLine = false;
               isFirstSymbol = true;

            }

            char currentCharacter = line[i];

            if (currentCharacter == '{')
            {
               if (!shouldPrintNewLine)
               {
                  if (!isFirstSymbol)
                  {
                     if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                     {
                        sb.Remove(sb.Length - 1, 1);
                     }
                     sb.AppendLine();
                  }
                  
               }

               AppendTabs();
               sb.Append(currentCharacter);
               tabsCount++;
               shouldPrintNewLine = true; //when there is a '{', go to the next line
            }
            else if (currentCharacter == '}')
            {
               tabsCount--;

               if (!shouldPrintNewLine)
               {
                  if (!isFirstSymbol)
                  {
                     if (sb.Length > 0 && char.IsWhiteSpace(sb[sb.Length - 1]))
                     {
                        sb.Remove(sb.Length - 1, 1);
                     }
                     sb.AppendLine();
                  }
               }

               AppendTabs();
               sb.Append(currentCharacter);
               shouldPrintNewLine = true;
            }
            else
            {
               if (isFirstSymbol)
               {
                  AppendTabs();
               }

               if(!(isFirstSymbol && char.IsWhiteSpace(currentCharacter)))
               {
                  if (!(i < line.Length - 1
                         && char.IsWhiteSpace(line[i])
                         && char.IsWhiteSpace(line[i + 1])))
                  {                                      
                     sb.Append(currentCharacter);                                    
                  }

                  isFirstSymbol = false;
               }              
            }
         }
         shouldPrintNewLine = true;
         isFirstSymbol = true;
      }

      private static void AppendTabs()
      {
         for (int i = 0; i < tabsCount; i++)
         {
            sb.Append(tabs);
         }
      }
   }
}
