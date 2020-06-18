//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/95/CSharp-Part-2-2013-2014-14-Sept-2013-Evening


namespace _06.Zerg
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   public class Zerg
   {
      const int NummeralSystemBase = 15;

      static void Main()
      {
         string zergMessage = Console.ReadLine();

         int position = zergMessage.Length / 4 - 1;

         long result = 0;

         for (int i = 0; i < zergMessage.Length; i += 4)
         {
            string currentDigit = zergMessage.Substring(i, 4);

            result += ConvertZergToInt(currentDigit) * PowerOfFifteen(position);

            position--;
         }

         Console.WriteLine(result);
      }



      static int ConvertZergToInt(string currentDigit)
      {
         switch (currentDigit)
         {
            case "Rawr": return 0; break;
            case "Rrrr": return 1; break;
            case "Hsst": return 2; break;
            case "Ssst": return 3; break;
            case "Grrr": return 4; break;
            case "Rarr": return 5; break;
            case "Mrrr": return 6; break;
            case "Psst": return 7; break;
            case "Uaah": return 8; break;
            case "Uaha": return 9; break;
            case "Zzzz": return 10; break;
            case "Bauu": return 11; break;
            case "Djav": return 12; break;
            case "Myau": return 13; break;
            case "Gruh": return 14; break;

            default: throw new ArgumentException();
         }         
      }



      static long PowerOfFifteen(int power)
      {
         long result = 1;

         for (int i = 0; i < power; i++)
         {
            result *= NummeralSystemBase;    
         }

         return result;
      }
   }
}
