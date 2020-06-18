using System;

namespace FromDecimal
{
   class FromDecimal
   {
      static string FromDecTo(int value, int numeralBase)
      {
         string result = "";
         do
         {
            int digit = value % numeralBase;
            value /= numeralBase;
            result = digit + result;
         }
         while (value > 0);

         return result;
      }



      static void Main()
      {
         Console.WriteLine(FromDecTo(13, 2));//13 in a binary
      }
   }
}
