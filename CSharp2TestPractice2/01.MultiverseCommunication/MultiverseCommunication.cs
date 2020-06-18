//http://bgcoder.com/Contests/94/CSharp-Part-2-2013-2014-14-Sept-2013-Morning

//http://my.telerikacademy.com/courses/Courses/Details/219

//One day, after eating too much pizza, the master-programmers Niki, Toni and Ivo started talking about “highly-intelligent” topics – how the universe started, who created it, are there other advanced forms of life, what kind of girls are hot and so on.Suddenly they received an answer from beyond to one of the biggest mysteries for the mankind – there is more than one universe in the space-time continuum! As a matter of fact – they are infinite – a multiverse to rule them all! How cool is that, huh?
//So, back to our story – somewhere in between the wormholes, dark matter and a lot of space-flying Zerg  Mutalisks, there was another universe almost identical to ours. The very same day after eating too much spaghetti, Ikin, Inot and Ovi (being well trained Terran Ghosts), decided to send telepathically an encrypted numerical message to our well-known software engineers.
//The sent message is made of the following digits:
//0	CHU
//1	TEL
//2	OFT
//3	IVA
//4	EMY
//5	VNB
//6	POQ
//7	ERI
//8	CAD
//9	K-A
//10	IIA
//11	YLO
//12	PLA
//The message is written as a sequence of digits.The last digit of the number (the most right one) has a value as shown in the above table.The next digit on the left has a value 13 times bigger than the shown in the above table, the next digit on the left has 13*13 times bigger value than the shown in the table and so on.Since our masters are too lazy after so much pizza and do not want to think(and code C# too), you task is to translate the message into its decimal representation. With your help, our heroes can fall asleep calmly, knowing other universes exist somewhere.
//Input
//The input data consists of a single line – the message from the parallel universe.
//The input data will always be valid and in the described format.There is no need to check it explicitly.
//Output
//The output data consists of a single line holding the calculated decimal representation of the given message number and should be printed at the console.
//Constraints
//•	The input number will have between 1 and 9 digits.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input     Output      Explanation
//OFT       2	         From the table OFT means 2 in 13th based numeral system. Message is 2. After converting it to decimal – the answer is 2.





namespace _01.MultiverseCommunication
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   class MultiverseCommunication
   {
      static void Main()
      {
         var alphabet = new List<string> {"CHU",
                                         "TEL",
                                         "OFT",
                                         "IVA",
                                         "EMY",
                                         "VNB",
                                         "POQ",
                                         "ERI",
                                         "CAD", 
                                         "K-A",
                                         "IIA",
                                         "YLO",
                                         "PLA",
                                         };

         var input = Console.ReadLine();

         long decimalRepresentation = 0;
         for (int i = 0; i < input.Length; i+= 3) //jumping over 3 because, the symbols are always 3
         {
            var digitIn13 = input.Substring(i, 3);
            var decimalValue = alphabet.IndexOf(digitIn13);


            decimalRepresentation *= 13;
            decimalRepresentation += decimalValue;
            
         }
         Console.WriteLine(decimalRepresentation);
      }
   }
}
