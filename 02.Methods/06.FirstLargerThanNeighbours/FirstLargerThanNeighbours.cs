using System;

//Description

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.

//Input
//•On the first line you will receive the number N - the size of the array
//•On the second line you will receive N numbers sepated by spaces - the array

//Output
//•Print the index of the first element that is larger than its neighbours or -1 if none are

//Constraints
//•1 <= N <= 1024
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 
//6
//-26 -25 -28 31 2 27

//Output:
//1 


namespace _06.FirstLargerThanNeighbours
{
   class FirstLargerThanNeighbours
   {

      //static int FirstLarger(int[] array)
      //{
      //   bool isBigger = false;
      //   int searchedIndex = 0;


      //   for (int i = 0; i < array.Length - 1; i++)
      //   {
      //      if (array[i] > array[i -1] && array[i]  > array[i + 1])
      //      {
      //         isBigger = true;
      //         searchedIndex = i;
      //         break;
      //      }
      //   }
      //   if (isBigger == true)
      //   {
      //      return searchedIndex;
      //   }
      //   else
      //   {
      //      return -1;
      //   }        
      //}


      //static void Main()
      //{      
      //   int lenght = int.Parse(Console.ReadLine());
      //   int[] array = new int[lenght];
      //   for (int i = 0; i < array.Length; i++)
      //   {
      //      Console.Write("Array [{0}]: ", i);
      //      array[i] = int.Parse(Console.ReadLine());

      //   }

      //   if (FirstLarger(array) != -1)
      //   {
      //      Console.WriteLine("The first number in the array that is larger than its neighbours is {0} and it is at the index {1}.", array[FirstLarger(array)], FirstLarger(array));
      //   }
      //   else
      //   {
      //      Console.WriteLine(FirstLarger(array));
      //   }

      //}

      //public static int IsBiggerThanNeighbour(int[] myArray)
      //{
      //   bool isBigger = false;
      //   int searchedIndex = 0;


      //   for (int index = 1; index < myArray.Length - 1; index++)
      //   {
      //      if ((myArray[index] > myArray[index + 1]) && (myArray[index] > myArray[index - 1]))
      //      {
      //         isBigger = true;
      //         searchedIndex = index;
      //         break;
      //      }
      //   }


      //   if (isBigger == true)
      //   {
      //      return searchedIndex;
      //   }
      //   else
      //   {
      //      return -1;
      //   }
      //}


      //static void Main()
      //{
      //   Console.Write("Please, initiate the size of your array: ");
      //   int arraySize = int.Parse(Console.ReadLine());
      //   int[] myArray = new int[arraySize];


      //   Console.ForegroundColor = ConsoleColor.DarkCyan;
      //   for (int i = 0; i < myArray.Length; i++)
      //   {
      //      Console.Write("element[{0}] = ", i);
      //      myArray[i] = int.Parse(Console.ReadLine());
      //   }


      //   if (IsBiggerThanNeighbour(myArray) != -1)
      //   {
      //      Console.ForegroundColor = ConsoleColor.Green;
      //      Console.WriteLine("The first number in given array which is bigger than\nhis neighbours is at position {0} and this number is {1}!", IsBiggerThanNeighbour(myArray), myArray[IsBiggerThanNeighbour(myArray)]);
      //   }
      //   else
      //   {
      //      Console.ForegroundColor = ConsoleColor.Green;
      //      Console.WriteLine(IsBiggerThanNeighbour(myArray));
      //   }
      //}

      static void ArrayInput(int lenght, int[] array)
      {
         string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         for (int i = 0; i < lenght; i++)
         {
            //Console.Write("Array [{0}]: ", i);
            array[i] = int.Parse(numbers[i]);
         }
      }


      static int FirstLarger(int lenght, int[] array)
      {
         int index = -1;
         for (int i = 1; i < lenght - 1; i++)
         {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
               return i;
            }
         }
         return index;
      }



      static void Main()
      {
         int lenght = int.Parse(Console.ReadLine());
         int[] array = new int[lenght];
         ArrayInput(lenght, array);

         Console.WriteLine(FirstLarger(lenght, array));
      }

   }
}
