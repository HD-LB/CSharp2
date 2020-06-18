//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/55/CSharp-Part-2-2012-2013-11-Feb-2013

//Joro's trying to top the leaderboard on "weirdest things by the lectors" (yep, couldn't think of a better translation). Last time he used Paint for a color picker on a CSS lecture, now he's inventing a whole new markup language – the Fake Text Markup Language. It looks a bit like HTML – it has opening and closing tags, and those tags define the formatting of text… on the console! So, if we receive an FTML formatted text, we need to print the text content according to the following rules:
//•	Tags can be opening and closing, e.g.: <upper> and</upper>
//•	Tags can be nested, e.g.: <upper> this is a<lower> nested tag</lower>  in another tag </upper>
//•	Nesting is measured in "depth", in this case <lower> is deeper than <upper>
//•	Tags cannot "intersect", e.g.: <upper> this is <lower> very</upper> wrong </lower> is not valid
//•	Tags don't appear in the resulting text, but they affect it
//•	When tags are nested, the effect of the "deepest" is considered first, then the effect of the less deeper and so on
//o e.g.: <upper>Before nested <lower>Inside nested</lower> After nested</upper> 
//will apply the effects of<lower> and then of <upper>
//o The end result will be: BEFORE NESTED INSIDE NESTED AFTER NESTED
//•	The<upper> tag converts text to its uppercase variant
//o e.g.: <upper>tExT</upper> results in: TEXT
//•	The<lower> tag converts text to its lowercase variant
//o e.g.: <lower>tExt</lower> results in: text
//•	The<toggle> tag:
//o  if a character is uppercase, it converts it to lowercase
//o	if a character is lowercase, it converts it to uppercase
//o  e.g. <toggle>tExT<toggle> results in: TeXt
//•	<upper>, <lower> and<toggle> tags don't affect punctuation or whitespaces
//•	The<del> tag deletes all text in it
//o  e.g.: this is <del> this is deleted</del> some text results in: this is some text
//•	The<rev> tag reverses all text in it
//o  e.g.: 123 reversed is <rev>123</rev> results in: 123 reversed is 321
//•	The FTML keeps all whitespaces and new lines(it doesn't remove them like HTML)
//o the only exception is, obviously, the<del> tag
//Write a program, which formats code, according to the rules described.
//Input
//On the first line of the input, there will be the number N – the number of lines in the FTML text.
//On each of the next lines there will be a line of the FTML text, consisting of English letters, punctuation and whitespaces (and of course FTML tags)
//Output
//On the console, you should print the lines of the formatted text.
//Constraints
//•	0 < N< 500
//•	The text input will NOT contain any '<' or '>', other than the ones for the tags
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input example                                                Output example
//2
//So<rev><upper> saw</upper> txet em</rev>
//<lower><upper>here</upper></lower>	                        Some text WAS
//                                                             here
//3
//<toggle><rev>ERa</rev></toggle> you
//<rev> noc</rev><lower>FUSED</lower>
//<rev>?<rev>already</rev></rev>	                              Are you
//                                                             confused
//                                                             already ?





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FTML
{
   class FTML
   {
      private const string RevTagOpen = "<rev>";
      private const string UpperTagOpen = "<upper>";
      private const string LowerTagOpen = "<lower>";
      private const string ToggleTagOpen = "<toggle>";
      private const string DelTagOpen = "<del>";

      private const string RevTagClose = "</rev>";
      private const string UpperTagClose = "</upper>";
      private const string LowerTagClose = "</lower>";
      private const string ToggleTagClose = "</toggle>";
      private const string DelTagClose = "</del>";

      private static int openedDelTags = 0;
      private static StringBuilder output = new StringBuilder();
      private static List<string> currentOpenTag = new List<string>();
      private static List<int> revTagStarts = new List<int>();

      static void Main()
      {
         int numberOfLines = int.Parse(Console.ReadLine());


         for (int i = 0; i < numberOfLines; i++)
         {
            string currentLine = Console.ReadLine();
            int currentSymbolIndex = 0;

            //reading Symbol for Symbol

            while (currentSymbolIndex < currentLine.Length)
            {
               if (currentLine[currentSymbolIndex] == '<')
               {
                  string tag = GetTag(currentLine, currentSymbolIndex);
                  ProcessTag(tag); //mark the Method + F12

                  currentSymbolIndex += tag.Length - 1;
               }
               else
               {
                  if (openedDelTags == 0)
                  {
                     char symbolToAdd = currentLine[currentSymbolIndex];

                     for (int j = currentOpenTag.Count - 1; j >= 0; j--)
                     {
                        symbolToAdd = ApplyEffects(symbolToAdd, currentOpenTag[j]);
                     }
                     output.Append(symbolToAdd);
                  }
               }

               currentSymbolIndex++; //jumping to the next Symbol
            }

            output.Append('\n');
         }
         Console.WriteLine(output.ToString().Trim());


      }

      private static char ApplyEffects(char symbolToAdd, string currentOpenTag)
      {
         if (char.IsLetter(symbolToAdd))
         {

            if (currentOpenTag == UpperTagOpen)
            {
               symbolToAdd = char.ToUpper(symbolToAdd);
            }
            else if (currentOpenTag == LowerTagOpen)
            {
               symbolToAdd = char.ToLower(symbolToAdd);
            }
            else if (currentOpenTag == ToggleTagOpen)
            {
               if (char.IsLower(symbolToAdd))
               {
                  symbolToAdd = char.ToUpper(symbolToAdd);
               }
               else
               {
                  symbolToAdd = char.ToLower(symbolToAdd);
               }
            }
         }
         return symbolToAdd;
      }

      private static void ProcessTag(string tag)
      {
         if (tag == DelTagOpen)
         {
            openedDelTags++;
         }
         else if (tag == DelTagClose)
         {
            openedDelTags--;
         }
         else
         {
            if (openedDelTags == 0)
            {
               if (tag == RevTagOpen)
               {
                  revTagStarts.Add(output.Length); //start reversing form here
               }
               else if (tag == RevTagClose) //reversing
               {
                  int currentRevStart = revTagStarts[revTagStarts.Count - 1];
                  int revEnd = output.Length - 1;
                  Reverse(currentRevStart, revEnd);
                  revTagStarts.RemoveAt(revTagStarts.Count - 1);

               }
               else if (tag[1] == '/')
               {
                  currentOpenTag.RemoveAt(currentOpenTag.Count - 1);
               }
               else
               {
                  currentOpenTag.Add(tag);
               }
            }
         }
      }

      private static void Reverse(int currentRevStart, int revEnd)
      {
         int start = currentRevStart;
         int end = revEnd;

         while (start < end)
         {
            //exchanging Places
            char bufferChar = output[start];
            output[start] = output[end];
            output[end] = bufferChar;

            end--;
            start++;
         }
       
      }

      private static string GetTag(string currentLine, int symbolIndex)
      {
         int tagStart = symbolIndex;
         int tagEnd = currentLine.IndexOf('>', tagStart + 1);

         string tag = currentLine.Substring(tagStart, tagEnd - tagStart + 1);

         return tag;
      }
   }
}
