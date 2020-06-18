using System;

namespace Test
{
   class Test
   {

      static int ParseInt(string number)
      {
         int result = 0;

         foreach (char digit in number)
         {
            result = result * 10 + (digit - '0');

         }
         return result;
      }


      static int ConvertToDec(string number, int numBase)// the user can give any Base
      {
         int result = 0;
         foreach (char digit in number)
         {
            result = result * numBase + (digit - '0');

         }
         return result;

      }



      static int ConvertFromHexToDec(string number)
      {
         int result = 0;

         foreach (char digit in number)
         {
            int digitValue;

            if (char.IsDigit(digit))
            {
               digitValue = digit - '0';
            }
            else
            {
               digitValue = digit - 'A' + 10;
            }
            result = 16 * result + digitValue;
         }

         return result;
      }



      static void Main()
      {
         string[] tests =
          {
            "1101",
            "11",
            "10",
            "1",
            "100",
            "1111"

         };
         foreach (string test in tests)
         {
            Console.WriteLine(ConvertToDec(test, 2));
         }



         string[] tests3 =
         {
            "1021",
            "2",
            "10",
            "11",
            "12",
            "20",
            "221"
         };         

         Console.WriteLine();

         foreach (string test in tests3)
         {
            Console.WriteLine(ConvertToDec(test, 3));
         }

         Console.WriteLine();



         string[] testsHex =
         {
            "321AB",
            "FE", 
            "1A",
            "ANCDEF",
            "AA",
            "10",
            "21"
         };
         foreach (string test in testsHex)
         {
            Console.WriteLine(ConvertFromHexToDec(test));
         }
      }
   }
}
