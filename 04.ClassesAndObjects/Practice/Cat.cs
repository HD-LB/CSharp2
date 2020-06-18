using System;

namespace Practice
{
   class Cat
   {
      //Fields:
      public const int NUM_OF_PAWS = 4; //the constant are written with capitals
      public const int MAX_AGE = 15;

      private string name; //making it "private" so only the Class Cat can access it     
      private int age;
      private int healthPoints;
      private bool hasTail;
      private bool isAlive;
          
           
      


      //Constructor
      public Cat() //(empty constructor) has to have the same name as the Class
      {
      }

      public Cat(string name, DateTime bDay)
      {
         Name = name;
         BirthDay = bDay; //it needs a property for the BirthDay
      }

      public Cat(string name, DateTime bDay, Gender gender)
         :this(name, bDay)
      {
         Gender = gender;
      }

      //Property
      public string Name    //prop + Tab Tab   //is connected to the Field string name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }
      //public string Name { get; set; }

      public DateTime BirthDay { get; private set; } //nobody can change the B'day --> private set
      public int Age
      {
         get
         {
            return DateTime.Now.Year -  BirthDay.Year;
         }
      }

      public bool IsAlive
      {
         get
         {
            bool isAlive = true;
            if (Age > MAX_AGE)
            {
               isAlive = false;
            }
            return isAlive;
         }
      }

      public Gender Gender { get; set; }

        //Methods:
        public void Eat(int calories)
        {
            healthPoints += calories / 10;
        }


        internal static void Scratch()
      {
         Console.WriteLine("Bad cat!");
      }

   }
}
