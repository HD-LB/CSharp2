using System;
using System.Text;
//http://my.telerikacademy.com/Courses/LectureResources/Video/5912/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-17-%d1%84%d0%b5%d0%b2%d1%80%d1%83%d0%b0%d1%80%d0%b8-2015-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be

namespace PracticeIvailo
{
   class Program
   {
      static Random rndGenerator = new Random(); //the Generator is global

      //Method
      static void InsertRandomSymbols(int count, StringBuilder password, string symbols)
      {
         for (int i = 0; i < count; i++)
         {
            char symbol = symbols[rndGenerator.Next(0, symbols.Length)];
            int rndPosition = rndGenerator.Next(0, password.Length);
            password.Insert(rndPosition, symbol);
         }
      }



      class Student
      {
         public string FirstName;

         public string LastName;
      }



      static void Main()
      {
         Student someStudent = new Student();
         someStudent.FirstName = "Pesho";
         someStudent.LastName = "Peshev";

         Student anotherStudent = new Student();
         anotherStudent.FirstName = "Gosho";
         anotherStudent.LastName = "Goshev";

         Console.WriteLine(someStudent.FirstName);
         Console.WriteLine(anotherStudent.FirstName);


         //Password
         StringBuilder password = new StringBuilder();

         string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
         string digits = "0123456789";
         string specialSymbols = "!@#$%^&*";

         InsertRandomSymbols(2,password, capitalLetters); //using the Method
         InsertRandomSymbols(2, password, lowerLetters);
         InsertRandomSymbols(1, password, digits);
         InsertRandomSymbols(3, password, specialSymbols);
         InsertRandomSymbols(rndGenerator.Next(0, 7), password, capitalLetters + lowerLetters + digits + specialSymbols);

         Console.WriteLine(password.ToString());
      }      
   }
   
}
