using System;
using System.Collections.Generic;
using System.Linq;

//Description

//Write a method that adds two polynomials.Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.

//Input
//•On the first line you will receive the number N
//•On the second line you will receive the first polynomial as coefficients separated by spaces
//•On the third line you will receive the second polynomial as coefficients separated by spaces

//Output
//•Print the sum of the polynomials

//Constraints
//•1 <= N <= 1024
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 3
//       5 0 1
//       7 4 -3

//Output: 12 4 -2 

//Example explanation:

//x2 + 5 = 1x2 + 0x + 5	=> { 5, 0, 1}

//-3x2 + 4x + 7 = -3x2 + 4x + 7	=> {7, 4, -3}

//(x2 + 5) + (-3x2 + 4x + 7) = (-2x2 + 4x + 12) = -2x2 + 4x + 12	=> {12, 4, -2}


namespace _11.AddingPolynomials
{
   class AddingPolynomials
   {
      static int[] SumOfArrays(int[] first, int[] second, int lenght)
      {
         int[] sum = new int[lenght];
         for (int i = 0; i < lenght; i++)
         {
            sum[i] = first[i] + second[i];
         }

         return sum;
      }

      

      static void Main()
      {
         int lenght = int.Parse(Console.ReadLine());

         int[] firstPolimial = Console.ReadLine()
                               .Split(' ')
                               .Select(n => int.Parse(n))
                               .ToArray();

         int[] secondPolimial = Console.ReadLine()
                               .Split(' ')
                               .Select(n => int.Parse(n))
                               .ToArray();

         int[] sum = SumOfArrays(firstPolimial, secondPolimial, lenght);

         Console.WriteLine(String.Join(" ", sum));
      }
   }
}
