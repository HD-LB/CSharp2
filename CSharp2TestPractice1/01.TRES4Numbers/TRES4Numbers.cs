using System;

//http://my.telerikacademy.com/Courses/Courses/Details/331

//http://my.telerikacademy.com/Courses/LectureResources/Video/8374/%d0%97%d0%b0%d0%b4%d0%b0%d1%87%d0%b0-TRES4-Numbers-%d0%9a%d1%80%d0%b8%d1%81%d1%82%d0%b8%d1%8f%d0%bd

//http://bgcoder.com/Contests/142/CSharp-Part-2-2013-2014-22-Jan-2014-Evening

//The largest planet in the known universe is TRES4.It is located in the constellation Hercules.For some strange coincidence the TRES4nians(the creatures that live on TRES4) use some of the letters in the Latin alphabet in their numeral system.What is even more surprising the digits in this numeral system, called TRESNUM4, also contain some operators that we use in programming here on Earth. All digits in TRESNUM4 with their decimal representations are:
//LON+	0
//VK-	1
//*ACAD 2
//^MIM  3
//ERIK|	4
//SEY&	5
//EMY>>	6
///TEL  7
//<<DON 8
//A long time ago, Christopher, an eleven years old kid from Arizona, USA, who was extremely good at physics and astronomy, sent a message with the integer coordinates of the Sun and the Earth to the constellation Hercules.Earlier today the message has been received by the TRES4nians. The problem is they don’t know how to convert numbers from decimal numeral system to numbers in TRESNUM4 numeral system and you, like the wisest TRES4nian, must help them by writing a computer program.
//Input
//The input data consists of a single line – the integer number sent to the TRES4 planet.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the TRESNUM4 number representation of the integer number.
//Constraints
//•	The input number will be between 0 and 18 000 000 000 000 000 000.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.

//Examples
//Input Output   Input  Output
//4	   ERIK|		154	VK-<<DONVK-

//Input   Output                 Input    Output
//5451	/TELERIK|* ACADEMY>>		891672	VK-EMY>>LON+<<DONVK-* ACADEMY>>




namespace _01.TRES4Numbers
{
   class TRES4Numbers
   {
      static void Main()
      {
         ulong number = ulong.Parse(Console.ReadLine());

          string[] tres4 =
         {
            "LON+",
            "VK-",
            "*ACAD",
            "^MIM",
            "ERIK|",
            "SEY&",
            "EMY>>",
            "/TEL",
            "<<DON"
         };

         int[] digits = new int[32];
         int digitCount = 0;

         do
         {
            digits[digitCount] = (int)(number % 9);//the most right digit
            number /= 9;

            digitCount++;
         } while (number > 0);


         for (int i = digitCount - 1; i >= 0; i--) //to read the number left to right
         {
            Console.Write(tres4[digits[i]]);
         }
         Console.WriteLine();
         
      }
   }
}
