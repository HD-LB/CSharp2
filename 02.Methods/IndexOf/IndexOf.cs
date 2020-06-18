using System;
namespace IndexOf
{
   class IndexOf
   {
      //
      static int Index(char[] symbols, char seekedValue)//searching for a particular char
      {
         //search for result and if found - return it

         for (int i = 0; i < symbols.Length; i++)
         {
            if (symbols[i] == seekedValue)
            {
               return i;
            }
         }

         return -1; //in case the char is not found
      }


      static void Main()
      {
         char[] symbols = "it's me".ToCharArray();

         int indexOfM = Index(symbols, 'm');
         int indexOfI = Index(symbols, 'i');
         int indexOfZ = Index(symbols, 'z');

         Console.WriteLine("{m - {0}", indexOfM);
         Console.WriteLine("{i - {0}", indexOfI);
         Console.WriteLine("{z - {0}", indexOfZ);
      }
   }
}
