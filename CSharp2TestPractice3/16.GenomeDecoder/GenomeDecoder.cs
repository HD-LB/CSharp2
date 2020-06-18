//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/10/CSharp-Fundamentals-2011-2012-Part-2-Test-Exam


//In modern molecular biology and genetics, the genome is the entirety of an organism's hereditary information. A genome sequence is a combination of the 4 Latin letters A, G, T and C.
//An encoded genome is a genome sequence where all sub-sequences of same consecutive letters(with length at least 2) are replaced with the length of the sub-sequence followed by the letter that is repeating.For example the genome sequence “AAGGGCTTT” will be encoded as “2A3GC3T”. The decoded genome is the original genome that is used for generating the encoded genome.In the given example the encoded genome is 2A3GC3T and the decoded genome is AAGGGCTTT.
//You will be given an encoded genome and your task is to decode it and then output it in a special format.You should output only N letters per line. On each line every M letters must be separated by a single space.At the start of each line you should print the line number (starting from 1) followed by a space.The line numbers should be aligned to the right using empty spaces(as shown in the second example). The last output line should not contain any spaces at the beginning nor the ending of the line.
//Input
//The input data should be read from the console.
//From the first input line you should read 2 integer numbers – N and M separated by a single space.
//From the second input line you should read the encoded genome sequence.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You should print the decoded genome in the format described.See the examples below.
//Constraints
//•	N will be an integer number between 1 and 1000, inclusive.
//•	M will be an integer between 1 and 1000, inclusive.M will be always lower than or equal to N.
//•	The encoded genome will contain only digits and the capital Latin letters ‘A’, ‘C’, ‘G’ and ‘T’.
//•	The length of the decoded genome will be between 1 and 100 000, inclusive.
//•	Allowed working time for your program: 0.15 seconds.Allowed memory: 16 MB.
//Examples
//Input example               Output example
//6 3
//10A15G3CA6T19C
//	1 AAA AAA
//2 AAA AGG
//3 GGG GGG
//4 GGG GGG
//5 GCC CAT
//6 TTT TTC
//7 CCC CCC
//8 CCC CCC
//9 CCC CCC


//Input example               Output example
//9 4
//18A13C10T10GA18GT17C
//	 1 AAAA AAAA A
// 2 AAAA AAAA A
// 3 CCCC CCCC C
// 4 CCCC TTTT T
// 5 TTTT TGGG G
// 6 GGGG GGAG G
// 7 GGGG GGGG G
// 8 GGGG GGGT C
// 9 CCCC CCCC C
//10 CCCC CCC


namespace _16.GenomeDecoder
{
   using System;
   using System.Text;

   class GenomeDecoder
   {
      static void Main()
      {
         string inputFormat = Console.ReadLine();
         string[] format = inputFormat.Split(' ');
         int lettersPerLine = int.Parse(format[0]);
         int lettersPerSubsequence = int.Parse(format[1]);

         string encodedGenome = Console.ReadLine();

         StringBuilder decodedGenome = DecodeGenome(encodedGenome);

         PrintFormattedOutput(decodedGenome, lettersPerLine, lettersPerSubsequence);
      }


      static void PrintFormattedOutput(StringBuilder decodedGenome, int lettersPerLine, int lettersPerSubsequence)
      {
         int oututLines = (int)Math.Ceiling((double)decodedGenome.Length / lettersPerLine);
         int maxLineNumberDigits = oututLines.ToString().Length;
         StringBuilder currentFormattingLine = new StringBuilder();
         int currentIndexInDecodedGenom = 0;

         for (int line = 1; line <= oututLines; line++)
         {
            string leadingIntervals = new string(' ', maxLineNumberDigits - line.ToString().Length);
            currentFormattingLine.Append(leadingIntervals);
            currentFormattingLine.Append(line);

            currentIndexInDecodedGenom = (line - 1) * lettersPerLine;
            for (int i = currentIndexInDecodedGenom ; i < line * lettersPerLine; i++)
            {
               if (Math.Abs(currentIndexInDecodedGenom - i) % lettersPerSubsequence == 0)
               {
                  currentFormattingLine.Append(' ');
               }

               if (i >= decodedGenome.Length)
               {
                  break;
               }

               currentFormattingLine.Append(decodedGenome[i]);
            }

            Console.WriteLine(currentFormattingLine);
            currentFormattingLine.Clear();
         }
      }


      static StringBuilder DecodeGenome(string encodedGenome)
      {
         StringBuilder decodedGenome = new StringBuilder();

         StringBuilder repeatTimesString = new StringBuilder();
         
         foreach (char symbol in encodedGenome)
         {
            if (symbol == 'A' || symbol == 'C' || symbol == 'G' || symbol == 'T')
            {
               int repeatTimes = 1; //how many should the letter be reapeaded

               if (repeatTimesString.Length != 0)
               {
                  repeatTimes = int.Parse(repeatTimesString.ToString());
                  repeatTimesString.Clear();
               }

               string genomesSubsequence = new string(symbol, repeatTimes);
               decodedGenome.Append(genomesSubsequence);
            }
            else
            {
               repeatTimesString.Append(symbol);
            }
         }

         return decodedGenome;
      }
   }
}
