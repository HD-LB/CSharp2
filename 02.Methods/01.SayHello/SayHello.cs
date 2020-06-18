using System;

//Description

//Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

//Input
//•On the first line you will receive a name

//Output
//•Print Hello, <name>!


namespace _01.SayHello
{
   class Program
   {
      static void SayHello(string name)
      {
         Console.WriteLine("Hello, {0}!", name);
      }
      static void Main()
      {
         string name = Console.ReadLine();
         SayHello(name);
      }
   }
}
