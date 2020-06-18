using System;

//Description

//Write a program that can solve these tasks:
//•Reverses the digits of a number
//•Calculates the average of a sequence of integers
//•Solves a linear equation a* x + b = 0

//Create appropriate methods.
//•Provide a simple text-based menu for the user to choose which task to solve.
//•Validate the input data: ◦The decimal number should be non-negative
//◦The sequence should not be empty
//◦a should not be equal to 0



namespace _13.SolveTasks
{
   class SolveTasks
   {
      //Reversed Number
      static string ReversedNumber(string number)
      {
         var reversedNum = number.ToCharArray();
         Array.Reverse(reversedNum);
         return new string(reversedNum);
      }
      static void PrintReversedNumber()
      {
         var number = Console.ReadLine();
         Console.WriteLine("THe Reversed Number is: " + ReversedNumber(number));
      }


      //Average Number
      static double Average(int[] array)
      {
         int sum = 0;
         for (int i = 0; i < array.Length; i++)
         {
            sum += array[i];
         }
         return (double)sum / array.Length;
      }
      static void PrintAverage()
      {
         int[] array = new int[int.Parse(Console.ReadLine())];
         for (int i = 0; i < array.Length; i++)
         {
            array[i] = int.Parse(Console.ReadLine());
         }
         if (array.Length > 0)
         {
            Console.WriteLine("The Average is: " + Average(array));
         }
         else
         {
            Console.WriteLine("Invalid input.");
         }
      }


      //Equation
      static double Equation(int a, int b)
      {
         return (double)-b / a;
      }
      static void PrintEquation()
      {
         int a = int.Parse(Console.ReadLine());
         int b = int.Parse(Console.ReadLine());
         Console.WriteLine("The Eqaution is: " + Equation(a, b));
      }

      
      //Calling the Methods
      static void Main()
      {
         Console.WriteLine("Press:/n 1 for ReversedNumber/n 2 for Avarege/n 3 for Equation: ");

         int n = int.Parse(Console.ReadLine());
         if (n == 1)
         {
            PrintReversedNumber();
         }
         else if (n == 2)
         {
            PrintAverage();
         }
         else
         {
            PrintEquation();
         }
      }
   }
}
