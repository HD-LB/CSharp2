using System;

namespace Testing
{
   class Testing
   {
      static void Main()
      {
         //Input 
         Console.Write("Size of the matrix will be: ");
         int size = int.Parse(Console.ReadLine());



         int[,] myArray = new int[size, size]; //Allocate our matrix with given size 



         //Main logic and initialize array elements about condition a): 
         int elementValue = 1;
         for (int col = 0; col < myArray.GetLength(1); col++)
         {
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
               myArray[row, col] = elementValue;
               elementValue++;
            }
         }





         MatrixPrint(myArray);



      }

      private static void MatrixPrint(int[,] myArray)
      {
         for (int row = 0; row < myArray.GetLength(0); row++)
         {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
               Console.Write("{0,4}", myArray[row, col]);
            }
         }
         Console.WriteLine();
      }






   }
}
