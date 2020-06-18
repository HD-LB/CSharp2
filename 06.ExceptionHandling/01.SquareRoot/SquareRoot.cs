using System;

//Write a program that reads a number and calculates and prints its square root.
//•If the number is invalid or negative, print Invalid number.
//•In all cases finally print Good bye.Use try-catch-finally block.

//Input
//•On the only line you will receive a real number

//Output
//•Print the square root of the number or Invalid number on the first line ◦Use 3 digits of precision

//•Print Good bye on the second line

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: number               4              -3.14                17

//Output: Invalid number      2000            Invalid number      4.123
//        Good bye            Good Bye        Good bye            Good bye



namespace _01.SquareRoot
{
   class SquareRoot
   {
      static void Main()
      {
         Console.WriteLine("Please insert a valid number: ");
         try
         {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(number));
         }
         catch (FormatException)
         {
            Console.WriteLine("Invalid number.");
         }
         catch (OverflowException)
         {
            Console.WriteLine("Invalid number.");
         }
         finally
         {
            Console.WriteLine("Good Bye!");
         }
      }
   }
}
