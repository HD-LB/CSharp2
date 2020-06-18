using System;

//Write a program that reads from the console a string of maximum 20 characters.If the length of the string is less than 20, the rest of the characters should be filled with*.

//Input
//•On the only line you will receive a string

//Output
//•Output a string with length 20

//Constraints
//•The length of the given string will be <= 20
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: hello                      -=StringOfLength20=-

//Output:  hello***************     -=StringOfLength20=- 



namespace _06.StringLenght
{
   class StringLenght
   {
      static void Main()
      {
         while (true)
         {
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
               continue;
            }
            else
            {
               Console.WriteLine(text.PadRight(20, '*'));
            }
         }
         
         
      }
   }
}
