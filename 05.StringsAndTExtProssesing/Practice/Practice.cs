using System;
using System.Linq;
using System.Text;

//http://my.telerikacademy.com/Courses/LectureResources/Video/9449/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-24-%d0%bd%d0%be%d0%b5%d0%bc%d0%b2%d1%80%d0%b8-2016-%d0%95%d0%b2%d0%bb%d0%be%d0%b3%d0%b8  - Evlogi

//http://my.telerikacademy.com/Courses/LectureResources/Video/5922/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-19-%d1%84%d0%b5%d0%b2%d1%80%d1%83%d0%b0%d1%80%d0%b8-2015-%d0%94%d0%be%d0%bd%d1%87%d0%be  - Doncho

//http://my.telerikacademy.com/Courses/LectureResources/Video/8331/%d0%92%d0%b8%d0%b4%d0%b5%d0%be-20-05-2016-%d0%9a%d0%be%d1%86%d0%b5%d1%82%d0%be  - Kozeto

namespace Practice
{
   class Practice
   {
      static void Main()
      {
         string str1 = "abc";
         string str2 = "zxw";

         var result = string.Compare(str1, str2);
         Console.WriteLine(result); //-1, not same


         string x = "0";
         string y = "23";
         int comparedResult = x.CompareTo(y);
         Console.WriteLine(comparedResult);


         string firstName = "Ivan";
         string lastName = "Ivanov";

         string result2 = string.Concat(firstName," ", lastName);
         Console.WriteLine(result2);



         string hello = "Hello, .NET!";
         for (int i = 0; i < hello.Length; i++)
         {
            Console.WriteLine(hello[i]);
         }




         //Seaching in String
         string name = "Telerik Academy";

         string searchedTerm = "Acad";
         int index = name.IndexOf(searchedTerm);
         string newStr = name.Substring(index, searchedTerm.Length);


         Console.WriteLine(newStr);
         Console.WriteLine("{0} found at {1}", newStr, index);

         string newStr1 = name.Substring(0, index);
         Console.WriteLine("{0} found at {1}", newStr1, index); //Telerik


         var sentence = "It's a beautiful day!";
         var piece = sentence.Substring(7);
         var piece1 = sentence.Substring(7, 9); //just the word "beautiful". Starts at index 7 with Lenght 9
         Console.WriteLine(piece);
         Console.WriteLine(piece1);



         //string fullname = "Peter Georgiev";
         //int index1 = fullname.IndexOf("e");
         //while (index >= 0 )
         //{
         //   Console.WriteLine("e is founf at index {0}.", index1);
         //   index1 = fullname.IndexOf("e", index1 + 1); 
         //}



         //
         string fileName = @"C:\Pics\Summer2009.jpg";

         int extInd = fileName.LastIndexOf('.');
         string extention = fileName.Substring(extInd + 1);// +1, so it's without the .

         int nameInd = fileName.LastIndexOf('\\') + 1;
         string nameOfFile = fileName.Substring(nameInd, extInd - nameInd);


         Console.WriteLine(nameOfFile);
         Console.WriteLine(extention);


         //Splitting Strings
         string list = "Amstel, Zagorka, Tuborg, Becks";
         var split = list.Split(new char[] { ',', ' ', '.' },StringSplitOptions.RemoveEmptyEntries);
         foreach (var str in split)
         {
            Console.WriteLine(str);
                               
         }
         string numList = "1, 2, 3, 4, 5, 6";
         int[] nums = numList.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); //using System.Linq
         foreach (var item in nums)
         {
            Console.WriteLine(item);
         }

         //Replacing
         string lingo = "Java and JavaScript";
         string replaced = lingo.Replace("Java", "C#");
         Console.WriteLine(replaced);

         //Trim
         Console.WriteLine("000000000111110011".TrimStart('0'));

         var binary = "11101";
         Console.WriteLine(binary.PadLeft(32,'0'));


         //StringBuilder
         StringBuilder sb = new StringBuilder();//using System.Text

         sb.AppendFormat("{0}", "string");
         sb.Insert(3, " another ");
         Console.WriteLine(sb);


         //Date
         DateTime now = new DateTime(2006, 7, 4, 3, 5, 6);
         Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}", now);


         //Formatting
         double pi = 3.1415;
         Console.WriteLine(pi.ToString("F2"));

      }
   }
}
