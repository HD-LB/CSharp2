using System;

//Write a program to check if in a given expression the(and ) brackets are put correctly.

//Input
//•On the only line you will receive an expression

//Output
//•Print Correct if the brackets are correct ◦Incorrect otherwise



//Constraints
//•1 <= length of expression <= 10000
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  ((a+b)/5-d)         )(a+b))


//Output:  Correct            Incorrect



namespace _03.CorrectBrackets
{
   class CorrectBrackets
   {
      static void Main()
      {
         string expression = Console.ReadLine();
         int counerOpenBracket = 0;
         int counerCloseBracket = 0;
         foreach (var ch in expression)
         {
            if (ch == '(')
            {
               counerOpenBracket++;
            }
            else if (ch == ')')
            {
               counerCloseBracket++;
            }
         }

         if (counerCloseBracket == counerOpenBracket)
         {
            Console.WriteLine("Correct");
         }
         else
         {
            Console.WriteLine("Incorrect");
         }
      }
   }
}
