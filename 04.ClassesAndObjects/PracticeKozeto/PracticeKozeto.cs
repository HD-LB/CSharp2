using System;
//http://my.telerikacademy.com/Courses/LectureResources/Video/8284/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-12-%d0%bc%d0%b0%d0%b9-2016-%d0%9a%d0%be%d1%86%d0%b5%d1%82%d0%be

namespace PracticeKozeto
{
   class PracticeKozeto
   {
      class Dog
      {
         //Fields:
         private int age;
         public string color;

         //Properties
         public int Age
         {
            get
            {
               return age;
            }
            set
            {
               age = value;
            }
         }

         //Methods
         public void PrintColor()
         {
            Console.WriteLine(color);
         }

      }
      static void Main()
      {
         Dog Pesho = new Dog();


         Pesho.Age = 3; //the set value
         Console.WriteLine(Pesho.Age); //get


         //returning the method
         Pesho.color = "Brown";
         Pesho.PrintColor(); 
      }
   }
}
