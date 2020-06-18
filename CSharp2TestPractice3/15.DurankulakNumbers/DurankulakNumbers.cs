//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/54/CSharp-Part-2-2012-2013-5-Feb-2013

//In Durankulak we have a special way to write numbers.We use the following 168 digits:
//A B  C  …	Z
//0	1	2	…	25
//…
//аA аB аC …	аZ
//26	27	28	…	51
//…
//bA bB bC …	bZ
//52	53	54	…	77
//…
//fA …	fJ fK fL
//156	…	165	166	167
//We write the numbers as sequences of digits.The last digit of the number (the most right one) has a value as shown in the above table.The next digit on the left has a value 168 times bigger than the shown in the above table, the next digit on the left has 168*168 times bigger value than the shown in the table and so on.Your task is to write a program to convert a Durankulak-style number into its corresponding decimal representation.
//Input
//The input data consists of a single string – a Durankulak-style number.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the calculated decimal representation of the given Durankulak-style number and should be printed at the console.
//Constraints
//•	The input string will have between 1 and 16 characters.
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input Output Input Output Input Output Input Output
//U	   20		bM      64		BaG   200	CfI   500


namespace _15.DurankulakNumbers
{
   using System;
   using System.Collections.Generic;

   class DurankulakNumbers
   {
      static void Main()
      {
         string[] durankulakDigits = GetDurankulakDigits();

         string durankulakNumber = Console.ReadLine();

         List<uint> decimalRepresentations = GetDecimalRepresentations(durankulakDigits, durankulakNumber);

         ulong decimalNumber = GetDecimalNumber(decimalRepresentations);

         Console.WriteLine(decimalNumber);

      }


      static ulong GetDecimalNumber(List<uint> decimalRepresentations)
      {
         ulong result = 0;
         for (int i = 0; i < decimalRepresentations.Count; i++)
         {
            result += decimalRepresentations[decimalRepresentations.Count - i - 1] * (ulong)Math.Pow(186, i);
         }
         return result;  
      }


      static List<uint> GetDecimalRepresentations(string[] durankulakDigits, string durankulakNumber)
      {
         List<uint> decimalRepresentations = new List<uint>();
         char buffer = new char(); // '\u000'

         foreach (char symbol in durankulakNumber)
         {
            if (symbol >= 'A' && symbol <= 'Z')
            {
               string durankulakDigit = null;
               uint decimalRepresentation = 0;

               if (buffer != default(char))
               {
                  durankulakDigit = string.Format("{0}{1}", buffer, symbol);
                  

                  buffer = default(char);
               }
               else
               {
                  durankulakDigit = symbol.ToString();
                  
               }
               decimalRepresentation = (uint)Array.IndexOf(durankulakDigits, durankulakDigit);
               decimalRepresentations.Add(decimalRepresentation);
            }

            else
            {
               buffer = symbol;
            }
         }

         return decimalRepresentations;
      }



      static string[] GetDurankulakDigits()
      {
         string[] durankulakDigits = new string[168];

         for (int i = 0; i < 168; i++)
         {
            if (i < 26)
            {
               durankulakDigits[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
               durankulakDigits[i] = "a" + durankulakDigits[i - 26];
            }
            else if (i < 3 * 26)
            {
               durankulakDigits[i] = "b" + durankulakDigits[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
               durankulakDigits[i] = "c" + durankulakDigits[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
               durankulakDigits[i] = "d" + durankulakDigits[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
               durankulakDigits[i] = "e" + durankulakDigits[i - 5 * 26];
            }
            else //if (i < 7 * 26)
            {
               durankulakDigits[i] = "f" + durankulakDigits[i - 6 * 26];
            }
         }
         
         return durankulakDigits; ;
      }

   }
}
