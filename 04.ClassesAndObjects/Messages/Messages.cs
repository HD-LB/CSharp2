using System;
using System.Numerics;

namespace Messages
{
   class Messages
   {
      static string[] numSystem = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

      static void Main()
      {
         string strOne = Console.ReadLine();
         string op = Console.ReadLine();
         string strTwo = Console.ReadLine();

         BigInteger numOne = Decrypt(strOne);
         BigInteger numTwo = Decrypt(strTwo);


         BigInteger numResult = (op == "+" ? numOne + numTwo : numOne - numTwo);

         string result = Encrypt(numResult);
         Console.WriteLine(result);
      }



      private static BigInteger Decrypt(string str)
      {
         BigInteger result = 0;

         for (int j = 0; j < str.Length; j += 3) //jumping over 3, because of the 3 letters in the string
         {
            string digit = str.Substring(j, 3);
            for (int i = 0; i < numSystem.Length; i++)
            {
               if (digit == numSystem[i])
               {
                  result = result * 10 + i;
               }
            }
         }
         return result;
      }



      private static string Encrypt(BigInteger num)
      {
         string result = string.Empty;

         int digit = 0;

         while (num > 0)
         {
            digit = (int)(num % 10); // and the next digit
            result = numSystem[digit] + result; //putting it on the end of the number
            num /= 10; //getting the most left digit
         }

         return result;
      }


   }
}
