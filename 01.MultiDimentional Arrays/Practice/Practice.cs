//http://my.telerikacademy.com/Courses/LectureResources/Video/5908/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-11-%d1%84%d0%b5%d0%b2%d1%80%d1%83%d0%b0%d1%80%d0%b8-2015-%d0%98%d0%b2%d0%b0%d0%b9%d0%bb%d0%be


using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
   class Practice
   {
      private static int row;

      static void Main()
      {
         ////Matrix of integers
         //int[,] numbers = new int[5, 10];
         //numbers[3, 2] = 100; //3rd row, 2nd column
         //Console.WriteLine(numbers[3, 2]);

         ////Matrix of text
         //string[,] words = new string[5, 5];

         //words[0, 0] = "Pesho";
         //words[0, 1] = "Gosho";


         ////Creating and initializing an multi array, 0, 1, 2 rows and 0, 1 columns
         //int[,] nums =
         //   {
         //      {1, 2},
         //      {2, 4},
         //      {5, 6}

         //   };


         ////Filling out a Matrix
         //int[,] matrix = new int[2, 3];

         //for (int row = 0; row < matrix.GetLength(0); row++)//when the lenght of the rows is unknown
         //{
         //   for (int col = 0; col < matrix.GetLength(1); col++)//when the lenght of the columns is unknown
         //   {
         //      int value = int.Parse(Console.ReadLine());
         //      matrix[row, col] = value;

         //   }            
         //}




         //string text = "1, 2, 3, 4";
         //string[] textParts = text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
         //foreach (var textPart in textParts)
         //{
         //   int someNumber = int.Parse(textPart);
         //}



         ////Printing a Matrix
         //int rows = int.Parse(Console.ReadLine());
         //int cols = int.Parse(Console.ReadLine());

         //int[,] matrixNums = new int[rows, cols];

         //for (int row = 0; row < rows; row++)
         //{

         //   for (int col = 0; col < cols; col++)
         //   {
         //      Console.Write("Enter matrix[{0}, {1}]", row, col);
         //      matrixNums[row, col] = int.Parse(Console.ReadLine());
         //   }
         //}
         //Console.WriteLine("Your matrix is: ");

         //for (int row = 0; row < rows; row++)
         //{
         //   for (int col = 0; col < cols; col++)
         //   {
         //      Console.Write("{0} ", matrixNums[row, col]);
         //   }
         //   Console.WriteLine();
         //}




         //// Printing a Matrix
         //int rows = int.Parse(Console.ReadLine());
         //int cols = int.Parse(Console.ReadLine());

         //int[,] matrixNums = new int[rows, cols];

         //for (int row = 0; row < rows; row++)
         //{
         //   Console.Write("Enter {0} row: ", row);
         //   string[] currentRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

         //   //if (currentRow.Length < matrixNums.GetLength(1))// in case the user enters more input than necessary 
         //   //{
         //   //   Console.Write("Error");
         //   //   break;
         //   //}

         //   for (int col = 0; col < matrixNums.GetLength(1); col++)
         //   {
         //      matrixNums[row, col] = int.Parse(currentRow[col]);
         //   }
         //}
         //Console.WriteLine("Your matrix is: ");

         //for (int row = 0; row < rows; row++)
         //{
         //   for (int col = 0; col < cols; col++)
         //   {
         //      Console.Write("{0, 5} ", matrixNums[row, col]);//"{0, 5} " formats the input 
         //   }
         //   Console.WriteLine();
         //}


         ////Max Sum
         //int[,] matrix =
         //{
         //   {7, 1, 3, 3, 2, 1 },
         //   {1, 3, 9, 8, 5, 5 },
         //   {4, 6, 7, 9, 1, 0 }

         //};

         //int maxSum = int.MinValue;
         //int maxRow = 0;
         //int maxCol = 0;

         //for (int row = 0; row < matrix.GetLength(0) - 1; row++)
         //{
         //   for (int col = 0; col < matrix.GetLength(1) - 1; col++)
         //   {
         //      int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
         //      if (sum > maxSum)
         //      {
         //         maxSum = sum;

         //         maxRow = row;
         //         maxCol = col;
         //      }
         //   }
         //}
         //Console.WriteLine("Max Sum is: {0}", maxSum);
         //Console.WriteLine("{0} {1}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1]);
         //Console.WriteLine("{0} {1}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1]);


         ////Jagged Arrays
         //int[][] numbers = new int[5][];

         ////numbers[0] = new int[3];
         ////numbers[1] = new int[4];

         //for (int i = 1; i < numbers.Length; i++)
         //{
         //   numbers[i] = new int[i];
         //}
         //Console.WriteLine(numbers);




         ////Jagged Array --> Example

         //int[][] jagged = new int[3][];

         //jagged[0] = new int[] { 1, 2, 3 };
         //jagged[1] = new int[] { 4, 5 };
         //jagged[2] = new int[] { 6, 7, 8, 9 };
         ////Printing
         //for (int row = 0; row < jagged.Lenght; row++)
         //{
         //   for (int col = 0; col < jagged[row].Lenght; col++)
         //   {
         //      Console.WriteLine("{0}, ", jagged[row][col]);

         //   }
         //   Console.WriteLine();
         //}



         ////Remainders of 3

         //int[] numbers = Enumerable.Range(1, 10).ToArray(); //makes an Array from 1 to 10
         //int[] numbers = new int[] { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };

         //int[][] remainders = new int[3][]; //for the remainders 0, 1, 2

         //int[] counter = new int[3];

         ////int zeroRemainder = 0;
         ////int oneRemainder = 0;
         ////int twoReaminder = 0; 

         //foreach (int number in numbers)
         //{
         //   int currentRemainder = number % 3;
         //   counter[currentRemainder]++;
         //}

         //for (int i = 0; i < counter.Length; i++)
         //{
         //   //remainders[i] = new int[counter[i]]; //second jagged array that prints the input numbers

         //   int currentCount = counter[i];
         //   remainders[i] = new int[currentCount];
         //}


         //int[] indexes = new int[3];


         ////int zeroIndex = 0;  //setting information until where the row is filled
         ////int oneIndex = 0;
         ////int twoIndex = 0;

         //for (int i = 0; i < numbers.Length; i++)
         //{
         //   int currentNumber = numbers[i];
         //   int remainder = currentNumber % 3; //the remailder can be 0, 1, 2 --> filling in the if-Statement

         //   //if (remainder == 0)
         //   //{
         //   //   remainders[remainder][zeroIndex] = currentNumber; //row 0 and the corrensponding column (zeroIndex)
         //   //   zeroIndex++;
         //   //}
         //   //else if (remainder == 1)
         //   //{
         //   //   remainders[remainder][oneIndex] = currentNumber;
         //   //   oneIndex++;
         //   //}
         //   //else if (remainder == 2)
         //   //{
         //   //   remainders[remainder][twoIndex] = currentNumber;
         //   //   twoIndex++;
         //   //}

         //   remainders[remainder][indexes[remainder]] = currentNumber; //row 0 and the corrensponding column (zeroIndex)
         //   indexes[remainder]++;
         //}


         ////List --> Example
         //int[] numbers = new int[] { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };

         //List<List<int>> remainders = new List<List<int>>();

         //for (int i = 0; i < 3; i++) //3 Elements
         //{
         //   remainders.Add(new List<int>());
         //}
         //for (int i = 0; i < numbers.Length; i++)
         //{
         //   int currentNumber = numbers[i];
         //   int remainder = currentNumber % 3;
         //   remainders[remainder].Add(currentNumber); //on tne row --> remainders[remainder], put the current Number
         //}



         ////Multiplication of two Matrix --> the rows == col!!!

         //int[,] first =
         //{
         //   {1, 2, 3 },
         //   {4, 5, 6 }
         //};


         //int[,] second =
         //{
         //   {7, 8 },
         //   {9, 10 },
         //   {11, 12 }
         //};

         //int rows = first.GetLength(0); // the rows of the first Matrix
         //int cols = second.GetLength(1); // the columns of the second Matrix

         //int[,] result = new int[rows, cols]; //making a Matrix for the Result
         //for (int row = 0; row < result.GetLength(0); row++)
         //{
         //   for (int col = 0; col < result.GetLength(1); col++)
         //   {
         //      int currentResult = 0; //the sum of all multiplications

         //      for (int element = 0; element < first.GetLength(1); element++) //the columns of the first Matrix
         //      {
         //         currentResult += first[row, element] * second[element, col];
         //      }
         //      result[row, col] = currentResult;
         //   }
         //}

         ////Printing?

         //for (int row = 0; row < result.GetLenght(0); row++)
         //{
         //   for (int col = 0; col < result.GetLenght(1); col++)
         //   {
         //      Console.Write(" " + result[row, col]);
         //   }
         //   Console.WriteLine();
         //}




         ////Pascal Triangle

         //int height = 10; //rows

         //int[][] triangle = new int[height][];

         //triangle[0] = new int[1];
         //triangle[0][0] = 1;


         //for (int row = 1; row < height; row++)
         //{
         //   triangle[row] = new int[row + 1]; //every next wor is + 1 more

         //   triangle[row][0] = 1; //the first column is alway 1

         //   for (int col = 1; col < row; col++) //filling in the sum inbetween the 1's
         //   {
         //      triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col]; //sum of the previous elements
         //   }

         //   triangle[row][row] = 1; //the last column is alway s 1


         //}

         //int count = 20;

         ////Printing the Triangle
         //for (int row = 0; row < triangle.Length; row++)
         //{
         //   Console.Write("".PadLeft(count));
         //   for (int col = 0; col < triangle[row].Length; col++)
         //   {
         //      Console.Write("{0, 3} ", triangle[row][col]); //printing the elements with 3 spaces
         //   }
         //   Console.WriteLine();

         //   count-= 2;
         //}


         ////Array Class
         //int[,] numbers = new int[3, 4];
         //Console.WriteLine(numbers.Rank); //2 --> 2 dimenstions
         //Console.WriteLine(numbers.Length); //the numbers of the cells 3 x 4 = 12
         //Console.WriteLine(numbers.GetLength(0)); // the first row


         //int[] nums = { 1, 2, 3, 8, 4, 5, 6 };
         //int index = Array.BinarySearch(nums, 4); 
         //Console.WriteLine(index); //find the 4 in nums, counts from 0

         //int[] numbers = Enumerable.Range(1, 100).ToArray();
         //int index = Array.BinarySearch(numbers, 5); //finds the index of the 5, in the range from 1 to 100
         //Console.WriteLine(index); //4, starting from the 0



         //int[] elements = { 5, 8, 1, 8, 2, 8, 6, 8 };
         ////int indexOf = Array.IndexOf(elements, 8); 
         ////Console.WriteLine(indexOf); //--> 2nd index

         ////int lastIndex = Array.LastIndexOf(elements, 8); 
         ////Console.WriteLine(lastIndex);//last 8 of the elements

         //int startIndex = 0;
         //while (true)
         //{
         //   int currentIndex = Array.IndexOf(elements, 8, startIndex); //looking for all the 8's starting from the startIndex
         //   if (currentIndex < 0)
         //   {
         //      break;
         //   }
         //   Console.WriteLine(currentIndex);
         //   startIndex = currentIndex + 1; 
         //}


         //int[] num = { 1, 2, 3, 4 };
         //int[] anotherNum = new int[num.Length];
         //Array.Copy(num, anotherNum, num.Length); //num is beeing coppied in anotherNum, the whole array(num.Lenght)
         //Console.WriteLine(string.Join(" ", anotherNum));

         //Array.Copy(num, 1, anotherNum, 2, 2);//start from the 1st element of the array num, coppy on the 2nd index of anotherNum, 2 elements
         //Console.WriteLine(string.Join(" ", anotherNum));


         //Array.Reverse(num);
         //Console.WriteLine(string.Join(" ", num));



         ////Spiral
         //int[,] spiral = new int[4, 4];

         //int counter = 1;
         //for (int col  = 0; col < 4; col++)
         //{
         //   for (int row = 0; row < 4; row++)
         //   {
         //      spiral[row, col] = counter;
         //      counter++;

         //   }

         //}







         //Input 
         //Console.WriteLine("Please set a values for the matrix sizes \"array[N, M]\""); 
         //Console.Write("N = "); 
         int n = int.Parse(Console.ReadLine()); 
         //Console.Write("M = "); 
         int m = int.Parse(Console.ReadLine());



         string[,] myArray = new string[n, m]; //Allocate our matrix with the given sizes 



         //Hardcoded test input array 
         //string[,] myArray =
         //    {
         //                { "ho", "fifi", "ho", "hi"},
         //                { "ha", "ha", "hi", "xx" },
         //                { "xxx", "ho", "ha", "xx" },
         //   };



         ////Initialize array elements 
         
         for (int row = 0; row < myArray.GetLength(0); row++)
         {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
               Console.Write("myArray[{0}, {1}] = ", row, col);
               string input = Console.ReadLine();
               myArray[row, col] = input;
            }
         }



         //Print matrix 
         Console.ForegroundColor = ConsoleColor.DarkMagenta;
         Console.WriteLine("Your array is:");
         for (int row = 0; row < myArray.GetLength(0); row++)
         {
            for (int col = 0; col < myArray.GetLength(1); col++)
            {
               Console.Write("{0, 5}", myArray[row, col]);
            }



            Console.WriteLine();
         }



      }
   }
}
