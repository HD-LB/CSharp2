//http://bgcoder.com/Contests/94/CSharp-Part-2-2013-2014-14-Sept-2013-Morning

//http://my.telerikacademy.com/courses/Courses/Details/219



//We are given a sequence of n magic words.The words are magic because they are capable to perform two “magic” operations: “reorder” and “print”.
//Reorder: The reordering operation over n words is performed by sequentially moving the words at positions 0, 1, …, n-1 to positions corresponding to their lengths.More precisely, first the word w0 from position 0 is moved to position len(w0) % (n+1), then the word w1 from position 1 is moved to position len(w1) % (n+1), and so on.Finally the word wn-1 from position n-1 is moved to position len(wn-1) % (n+1). Note that positions are numbered from 0 to n and position 0 is just before the leftmost word and position n is just after the rightmost word.
//For example, if we have n = 3 words {"hi", "academy", "exam"}, they will be reordered 3 times this way:
//Position 0	1	2	0  2	Position 0	1	2	1  2
//Word hi academy exam     Word academy  hi exam


//Position 0	1	2	2  0	Position 0	1	2	
//Word academy  hi exam     Word exam  academy hi
//Print: The printing process is simple.It just first prints the first letter of all words, then the second letter of all words (when it exists), then the third letter of all words (when exists), etc. As a result the printing obtains a sequence of letters from the input words.
//Your task is to write a program that reads n words, performs the magic operations “reorder” and “print” over them and outputs the obtained sequence of letters.
//Input: The input data should be read from the console. The first line holds a single integer number n. At each of the next n lines there is a single word.
//Output: The output data consists of a single text line holding the obtained result.
//Constraints
//•	The number of words n will be in the range [1...1000].
//•	Each word will have between 0 and 1000 English letters, each in the range [a…z].
//•	Allowed working time for your program: 0.06 seconds.
//•	Allowed memory: 32 MB.
//Examples
//Input     Output 
//3         eahxciaamdemy		
//hi
//academy
//exam
//Input   Output 
//2        wyionu
//you
//win 		
//Input     Output 
//1         hi
//hi 		
//Input        Output 
//4             wnptrarhokoitobsevlem
//nakov
//wrote
//this
//problem

namespace _02.MagicWords
{

   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;

   class MagicWords
   {
      static void Main()
      {

         int n = int.Parse(Console.ReadLine()); //Number of Words
         var words = new List<string>(); //the Words
         for (int i = 0; i < n; i++)
         {
            words.Add(Console.ReadLine()); //Reading the Words
         }

         //Reorder
         for (int i = 0; i < n; i++)
         {
            var word = words[i]; //the word is thw word with an index [i]
            var newIndex = word.Length % (n + 1); //as per instructions

            words.Insert(newIndex, word);

            if (newIndex < i)
            {
               words.RemoveAt(i + 1);
            }
            else
            {
               words.RemoveAt(i);
            }      

         }


         //Print

         var maxLenght = 0;
         foreach (var word in words)
         {
            maxLenght = Math.Max(maxLenght, word.Length);
         }
         //var maxLenght = words.Max(x => x.Lenght);


         var result = new StringBuilder();
         for (int i = 0; i < maxLenght; i++)
         {
            foreach (var word in words)
            {
               if (word.Length > i)
               {
                  result.Append(word[i]);
               }               
            }
         }

         Console.WriteLine(result.ToString());



      }
   }
}
