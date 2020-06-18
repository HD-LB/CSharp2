using System;

//Description

//Write a method that reverses the digits of a given decimal number.

//Input
//•On the first line you will receive a number

//Output
//•Print the given number with reversed digits

//Constraints
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:    256       652 

//Output:   123.45    54.321 



namespace _07.ReverseNumber
{
   class ReverseNumber
   {

      //static int ReversedNum(int number)
      //{
      //   int temp = 0;
      //   while (number > 0)
      //   {
      //      temp = (temp * 10) + (number % 10);
      //      number /= 10;
      //   }
      //   return temp;
      //}
      //static void Main()
      //{
      //   int number = int.Parse(Console.ReadLine());
      //   Console.WriteLine(ReversedNum(number)); 
      //}

     static string ReversedNumber(string number)
      {
         var reversedNum = number.ToCharArray();
         Array.Reverse(reversedNum);
         return new string(reversedNum);
      }
      static void Main()
      {
         var number = Console.ReadLine();
         Console.WriteLine(ReversedNumber(number));
      }
   }
}
