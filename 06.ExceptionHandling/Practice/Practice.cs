using System;

namespace Practice
{
   class Practice
   {
      static void ReadNumber()
      {
         
         
            int a = int.Parse(Console.ReadLine());
            int result = 10 / a;
        
      }
      static void Main()
      {
         
         try
         {
            //int a = int.Parse(Console.ReadLine());
            //int result = 10 / a;

            ReadNumber();
         }
         catch (FormatException)
         {

            Console.WriteLine("Input invalid!"); ;
         }
         catch (DivideByZeroException ex)
         {
            Console.WriteLine("You cannot enter 0!");
            Console.WriteLine(ex.Message); //formatted message
            Console.WriteLine(ex.StackTrace); //in wich Method is the Exeption
         }
      }
   }
}
