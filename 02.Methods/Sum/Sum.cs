using System;

namespace Sum
{
   class Sum
   {

      static int Product(params int[] numbers) 
      {
         int product = 1;
         foreach (int n  in numbers)
         {
            product *= n;
         }

         return product;
      }

      static void Main()
      {
         int p1 = Product(1, 2, 0, 15);
         int p2 = Product(3, 4, -6);
         int p3 = Product(28, 77, 456, 121, 10);

         Console.WriteLine(p1);
         Console.WriteLine(p2);
         Console.WriteLine(p3);
      }
   }
}
