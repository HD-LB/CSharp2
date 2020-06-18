using System;
//http://my.telerikacademy.com/Courses/LectureResources/Video/9440/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-22-%d0%bd%d0%be%d0%b5%d0%bc%d0%b2%d1%80%d0%b8-2016-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8

namespace Practice
{
   class Practice
   {
      static void Main()
      {
         DateTime bDay = new DateTime(1998, 3, 12);
        // Cat myCat = new Cat(); 
        Cat myCat = new Cat("Suzi", bDay, Gender.Female); // the Class is Cat, the Object is suzi


         myCat.Name = "Suzi"; //setting a value
         Console.WriteLine("The cat's name is: {0}",  myCat.Name); //getting the value .Name

         Cat.Scratch(); //Ctrl + . makes an internal Class

         Console.WriteLine(Cat.NUM_OF_PAWS);
         Console.WriteLine("{0} is {1} years old.", myCat.Name, myCat.Age);
         Console.WriteLine("Is {0} alive? {1}.", myCat.Name, myCat.IsAlive);
      }
   }
}
