﻿//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/52/CSharp-Part-2-2012-2013-4-Feb-2013-Morning

//Joro is having problems.He broke his PC (and his bed, and another bed, and several glasses, and several other things…) on his birthday party and has to write the description of the next task for the PC Magazine & Telerik programming contest.Now, Joro has a very old PC, which can only run a console.Sure, he can use that to write the description, but there’s a small problem.The console can’t justify the text, like MS Word can – Joro needs that functionality, and he needs it fast!
//He decided that he can do justification by placing additional whitespaces between the words, by following some rules regarding the justified text:
//1.	A word is separated from other words by at least one whitespace (or new line)
//2.	Each line must have a fixed width W – number of symbols including whitespaces – Joro knows this width in advance
//o  This width will be at least the length of the longest word in the text
//3.Each line must have at least one word, and each word can be on exactly one line
//o  E.g.a word cannot have several characters on one line and several on the next
//4.If a line contains exactly one word, there must be no whitespaces after it – this is the only case in which the line can have a width less than W
//5.We will call the whitespaces between two consecutive words “gaps”
//6.One gap can have at most 1 whitespace more than any other gap
//7.One gap cannot have more whitespaces than any other gap to its left
//o  So, a gap can have a whitespace more than another gap “on its right”, but not vice versa
//8.Justification happens by fitting as much words as possible on one line, and continuing with the next
//o  The first line is formed by taking all words that can fit on that line from the text
//o  The next line is formed by taking all words that can fit on that line from the remaining text, and so on…
//o  The order of the letters in the text(excluding whitespaces) must remain the same
//Write a program which justifies text, by using whitespaces, according to the rules described.Note that just placing each word from the text on a separate line could be a violation of rule 8.
//Input
//The input data should be read from the console.
//On the first line of the input there will be the number N – the total number of lines in Joro’s initial text.
//On the next line of the input there will be the number W – the number of symbols, of which each of the justified text lines must consist
//Each of the next N lines will contain a line of Joro’s text, consisting of Latin letters and whitespaces (a line in the input text will have at least one word on it)
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print the justified text, line by line, with each line having exactly W characters (unless it contains exactly one word, in which case it must have exactly as many characters as there are in the word). 
//Constraints
//•	0 < N< 1000
//•	0 < W< 10000, no word will have more than W symbols
//•	There will be no empty lines in the input
//•	There can be sequences of whitespaces in the input
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input example                                                    Output example
//5
//20
//We happy few        we band
//of brothers for he who sheds
//his blood
//with
//me shall be my brother                                          We happy few we band
//                                                                of  brothers  for he
//                                                                who  sheds his blood
//                                                                with  me shall be my
//                                                                brother
//10
//18
//Beer beer beer Im going for 
//   a
//beer
//Beer beer beer Im gonna
//drink some beer
//I love drinkiiiiiiiiing
//beer
//lovely
//lovely
//beer                                                            Beer  beer beer Im
//                                                                going  for  a beer
//                                                                Beer  beer beer Im
//                                                                gonna  drink  some
//                                                                beer     I    love
//                                                                drinkiiiiiiiiing
//                                                                beer lovely lovely
//                                                                beer


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConsoleJustification
{
   class ConsoleJustification
   {
      static void Main()
      {
         Queue<string> words = new Queue<string>();
         Queue<string> outputLineWords = new Queue<string>();

         int linesCount = int.Parse(Console.ReadLine());
         int maxAllowedLineLength = int.Parse(Console.ReadLine());


         string currentInputLine;
         //int currentLineLength = 0;
         string inputLine = Console.ReadLine();
         int inputLineNumber = 1;

         ExtractWordsFromLine(inputLine, words);

         int currentWordsLength = 0;
         int gapSize = 0;
         int additionalWhiteSpacesNeeded = 0;
         bool singleWordOnLine = false;
         bool shouldPrint = false;


         string currentOutputLine = String.Empty;
         string currentOutputWord = String.Empty;
         string currentWord = String.Empty;


         while (words.Count > 0 || outputLineWords.Count > 0)            
         {
            if (words.Count > 0)
            {
               currentWord = words.Peek(); //checking the first word
            }
            else
            {
               shouldPrint = true;
               //maxAllowedLineLength - (currentOutputLine.Length - outputLineWords.Count + 1)
               int symbolsRemaining = maxAllowedLineLength - currentOutputLine.Length - outputLineWords.Count + 1;

               if (outputLineWords.Count > 1)
               {
                  singleWordOnLine = false;
                  gapSize = symbolsRemaining / (outputLineWords.Count - 1);
                  additionalWhiteSpacesNeeded = symbolsRemaining % (outputLineWords.Count - 1);
               }
               else
               {
                  //only one word on the line
                  singleWordOnLine = true;

               }
            }
            

            if (currentWordsLength + outputLineWords.Count + currentWord.Length <= maxAllowedLineLength) // at the beginning of the sentance there is no space
            {
               outputLineWords.Enqueue(words.Dequeue()); // putting the current word to the line
               currentWordsLength += currentWord.Length;

               if (currentWordsLength + outputLineWords.Count - 1 == maxAllowedLineLength)
               {
                  shouldPrint = true;
               }
               else
               {
                  shouldPrint = false;
               }
            }
            else //when the Length of the words and the spaces is too long
            {
               shouldPrint = true;
               //maxAllowedLineLength - (currentOutputLine.Length - outputLineWords.Count + 1)
               int symbolsRemaining = maxAllowedLineLength - currentOutputLine.Length - outputLineWords.Count + 1;

               if (outputLineWords.Count > 1)
               {
                  singleWordOnLine = false;
                  gapSize = symbolsRemaining / (outputLineWords.Count - 1);
                  additionalWhiteSpacesNeeded = symbolsRemaining % (outputLineWords.Count - 1);
               }
               else
               {
                  //only one word on the line
                  singleWordOnLine = true;

               }
            }

            if (inputLineNumber == linesCount && words.Count == 0 && outputLineWords.Count != 0 && !shouldPrint)
            {

               shouldPrint = true;
            }

            if (shouldPrint)
            {
               
               if (singleWordOnLine)
               {
                  currentOutputWord = outputLineWords.Dequeue();
                  currentOutputLine += currentOutputWord;
                
               }
               else
               {
                  while (outputLineWords.Count > 1)
                  {
                     currentOutputWord = outputLineWords.Dequeue();

                     currentOutputLine += currentOutputWord + new string(' ', gapSize + 1);

                     if (additionalWhiteSpacesNeeded > 0)
                     {
                        currentOutputLine += ' ';
                        additionalWhiteSpacesNeeded--;
                     }
                  }

                  currentOutputWord = outputLineWords.Dequeue();

                  currentOutputLine += currentOutputWord;

               }

               Console.WriteLine(currentOutputLine);
               currentOutputLine = String.Empty;
               currentWordsLength = 0;
            }

            //Output
            if (words.Count == 0 && inputLineNumber < linesCount)
            {
               inputLine = Console.ReadLine();
               inputLineNumber++; //go on the next line
               ExtractWordsFromLine(inputLine, words);
            }

         }
      }


      private static void ExtractWordsFromLine(string inputLine, Queue<string> words)
      {
         string[] wordsOnLine = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         for (int index = 0; index < wordsOnLine.Length; index++)
         {
            string word = wordsOnLine[index];
            words.Enqueue(word);
         }
      }
   }
}
