//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/52/CSharp-Part-2-2012-2013-4-Feb-2013-Morning

//In Kaspichan we have a special way to write numbers.We use the following 256 digits:
//0	A     26	aA    52	bA …	234	iA
//1	B     27	aB    53	bB    235	iB
//…	…		…	…		…	…		…	…
//25	Z     51	aZ    77	bZ    255	iV
//We write the numbers as sequences of digits.The last digit of the number (the most right one) has a value as shown in the above table.The next digit on the left has a value 256 times bigger than the shown in the above table, the next digit on the left has 256*256 times bigger value than the shown in the table and so on.Your task is to write a program to convert a decimal number into its corresponding representation in Kaspichan.
//Input
//The input data consists of a single integer number.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single text line holding the result and should be printed at the console.
//Constraints
//•	The input number is in the range [0…18 446 744 073 709 551 615] inclusively.
//•	Allowed work time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Input  Output    Input    Output   Input   Output   Input    Output
//20	      U        30	      aE     280	      BY    1000	    DhY



namespace _18.KaspichanNumbers
{
   using System;
   using System.Collections.Generic;

   class KaspichanNumbers
   {
      static void Main()
      {
         ulong n = ulong.Parse(Console.ReadLine());

         List<string> digits = new List<string>();

         for (char i = 'A'; i <= 'Z'; i++)
         {
            digits.Add(i.ToString());
         }

         for (char i = 'a'; i <= 'i'; i++)
         {
            for (char j = 'A'; j <= 'Z'; j++)
            {
               digits.Add(i.ToString() + j.ToString());
            }
         }

         //foreach (var item in digits)
         //{
         //   Console.Write(item +  " " );
         //}

         string result = "";

         if (n == 0)
         {
            Console.WriteLine("A");
         }

         while (n != 0)
         {
            result = digits[(int)n % 256] + result;
            n = n / 256;
         }

         Console.WriteLine(result);

      }
   }
}
