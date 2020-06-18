using System;
using System.Collections.Generic;

namespace Practice
{
   class Practice
   {
      private static int i;

      ////Method
      //static void PrintFirstTenNumbers()
      //{
      //   for (int i = 0; i < 10; i++)
      //   {
      //      Console.WriteLine(i);
      //   }

      //}
      //static void Main()
      //{
      //   PrintNumbers();
      //}




      ////String  
      //static void Print(string text, int count)
      //{
      //   for (int i = 0; i < count; i++)
      //   {
      //      Console.WriteLine(text);
      //   }         
      //}
      //static void Main()
      //{
      //   Print("Hello!", 5);
      //   Print("Hiya!", 3);
      //}


      static void PrintMatrix(int[,] matrix)
      {
         for (int row = 0; row < matrix.GetLength(0); row++)
         {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
               Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();

         }

      }

      //static int[,] ReadMatrix(int rows, int columns) //creating matrix with int from the user
      //{
      //   int[,] result = new int[rows, columns];

      //   for (int row = 0; row < rows; row++)
      //   {
      //      for (int col = 0; col < columns; col++)
      //      {
      //         result[row, col] = int.Parse(Console.ReadLine());

      //      }
      //   }

      //   return result;
      //}



      static void Main()
      {
         int[,] matrix =
         {
            {1, 2, 3, 4, 5 },
            {-10, 15, 32, 34, 1 },
            {1, 1, 1, 2, 2 },
            {-5, -6, -7, -8, 7 }
         };

         int[,] table =
         {
            {5, 8, 10},
            {6, 3, 3},
            {10, 11, 12}
         };

         PrintMatrix(matrix);
         Console.WriteLine("====================");
         PrintMatrix(table);



         //int r = int.Parse(Console.ReadLine());
         //int c = int.Parse(Console.ReadLine());
         //int[,] matrixFromConsole = ReadMatrix(r, c);
         //PrintMatrix(matrixFromConsole);

      }



      ////Recursion
      //static void PrintNumbers()
      //{
      //   Console.WriteLine(1);
      //   PrintNumbers();
      //}
      //static void Main()
      //{
      //   PrintNumbers();
      //}


      ////Method Parameters
      //static void PrintSign(int number) //from now on, the Method can use only int
      //{
      //   if (number > 0)
      //   {
      //      Console.WriteLine("+");
      //   }
      //   else if (number < 0)
      //   {
      //      Console.WriteLine("-");
      //   }
      //   else
      //   {
      //      Console.WriteLine("0");
      //   }
      //}
      //static void Main()
      //{
      //   PrintSign(5); //the Metod PrintSign has to have a number(int)
      //   PrintSign(10);
      //   PrintSign(0);
      //   PrintSign(-100);
      //}


      ////Many Parameters
      //static void Sum(int firstNumber, int secondNumber)
      //{
      //   Console.WriteLine(firstNumber + secondNumber);
      //}
      //static void Main()
      //{
      //   Sum(5, 6); 
      //}


      ////Example
      //static void ProductOfThreeNumbers(double firstNum, double secondNum, double thirdNum)
      //{
      //   Console.WriteLine(firstNum * secondNum * thirdNum);
      //}
      //static void Main()
      //{
      //   ProductOfThreeNumbers(3.5, 4.9, 9.0);
      //   CreateNewString('%', 5);
      //}
      //static void CreateNewString(char symbol, int count)
      //{
      //   Console.WriteLine(new string(symbol, count));
      //}



      ////Example --> List
      //static void ChangeList(List<int> list)
      //{
      //   Console.WriteLine(list[0]);
      //}
      //static void Main()
      //{
      //   List<int> numbers = new List<int>();
      //   numbers.Add(50);
      //   ChangeList(numbers);
      //}




      ////Months
      //static void SayMonth(int month)
      //{
      //   string[] months =
      //   {
      //      "Jan",
      //      "Feb",
      //      "Mar",
      //      "Apr"
      //   };
      //   Console.Write(months[month - 1]); //the array starts form 0
      //}
      //static void PrintPeriod(int firstMonth, int secondMonth)
      //{
      //   int period = secondMonth - firstMonth;
      //   if (period < 0)
      //   {
      //      period += 12;
      //   }
      //   Console.Write("From ");
      //   SayMonth(firstMonth);
      //   Console.Write(" to ");
      //   SayMonth(secondMonth);
      //   Console.WriteLine(" there are {0} months.", period);
      //}
      //static void Main()
      //{
      //   PrintPeriod(1, 3);
      //}



      ////Triangle
      //static void Print(int max)
      //{

      //      for (int col = 1; col <= max; col++)
      //      {
      //         Console.Write(col + " ");
      //      }
      //      Console.WriteLine();         
      //}


      //static void Main()
      //{
      //   int n = int.Parse(Console.ReadLine());

      //   for (int row = 0; row <= n; row++)
      //   {
      //      Print(row);
      //   }

      //   for (int row = 1; row < n; row++)
      //   {

      //      Print(n - row);
      //   }
      //}




      ////Optional Parameters
      //static void PrintSum(int a, int b, int c = 0)
      //{
      //   Console.WriteLine(a + b + c);
      //}
      //static void Main()
      //{
      //   PrintSum(5, 6);
      //   PrintSum(5, 6, 7); //c is optional
      //}


      ////Return
      //static int Sum(int a, int b)
      //{
      //   return a + b;
      //}
      //static void Main()
      //{
      //   int result = Sum(1, 2);
      //   int anotherResult = Sum(5, 6);

      //   Console.WriteLine(result);
      //   Console.WriteLine(anotherResult);
      //}



      ////Bool
      //static bool ArePositiv(int[] numbers)
      //{
      //   foreach (var number in numbers)
      //   {
      //      if (number < 0)
      //      {
      //         return false;
      //      }
      //   }
      //   return true;
      //}
      //static void Main()
      //{
      //   int[] numbers = { 1, 2, 3, 4, 5 };
      //   Console.WriteLine(ArePositiv(numbers));
      //}

      ////Numbers
      //static int Sum(params int[] numbers) //the user can give an undefined amount of numbers
      //{
      //   int sum = 0;
      //   foreach (var number in numbers)
      //   {
      //      sum += number;
      //   }
      //   return sum;
      //}
      //static void Main()
      //{
      //   Sum(1, 2, 3, 4);
      //   Sum(0);
      //   Sum(1, 2, 3, 4, 5, 6);
      //   Sum();
      //}
   }
}
