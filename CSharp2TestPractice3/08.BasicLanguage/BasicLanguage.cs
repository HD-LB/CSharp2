//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/8/Telerik-Academy-Exam-2-7-Feb-2012

//Dancho likes only odd programming languages(the one he loves the most is called MSIL, of course). Few days ago he invented a new programming language.He called it BL (Basic Language).
//The BL consists of only 3 commands: PRINT, FOR and EXIT.All commands in a BL program are executed consecutively one by one following the rules explained bellow.
//The PRINT command has the following syntax: PRINT(<text to print>); where<text to print> is a consequence of symbols(all symbols are allowed except for the symbol “)”) with length between 0 and 100 000, inclusive.The PRINT command outputs the text inside the circle brackets.
//Note that the BL language ignores all spaces and line breaks because spaces and line breaks do not affect the semantics of the language.Of course, the spaces and the line breaks inside PRINT command should not be ignored.
//The FOR command represents a loop in BL.It has 2 forms:
//•	FOR(a) – The next command will be executed exactly a number of times.a will be positive integer between 0 and 2 000 000 000, inclusive.
//•	FOR(a, b) – The next command will be executed exactly b – a + 1 number of times.a will always be less than b.a and b will be integer numbers between -2 000 000 000 and 2 000 000 000, inclusive.
//Loops in the BL can be nested.For example, the following code: FOR(-2,-1) FOR( 100 ) PRINT(x); will output 200 times the letter x.
//The EXIT; command means the end of every BL program.When EXIT; is reached the program ends immediately.
//Dancho does not know C# (because C# is not one of the strangest programming languages), so help Dancho execute his own programming language (BL) by writing a program in C# that reads a valid BL code from the console, executes it and writes the BL code output on the console.
//Input
//The input data should be read from the console.
//The input will consist of valid code written in Basic Language(BL), always ending with the EXIT; command.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must write on the console the output result from executing the BL code given in the input.
//At the end of your output you must print a new line character.
//Constraints
//•	The input data will be no longer than 100 000 symbols.
//•	The input data will always be valid Basic Language syntax.
//•	None combination of FOR loops in the BL code will produce more than 1018 iterations.
//•	The output data will be no longer than 1 000 000 symbols.
//•	Allowed working time for your program: 0.2 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input example                                    Output example
//PRINT(Black and yellow, );
//FOR(0,1)PRINT(black and yellow, );
//PRINT(black and yellow...);
//EXIT;	                                          Black and yellow, black and yellow, black and yellow, black and yellow...

//FOR   ( 1  ,   5   )    PRINT(ha);
//FOR(2)FOR(2,3)PRINT(xi);PRINT(i); EXIT;    	   hahahahahaxixixixii




namespace _08.BasicLanguage
{
   using System;
   using System.Collections.Generic;
   using System.Text;

   class BasicLanguage
   {

      private static StringBuilder output = new StringBuilder();
      static List<string> allCommands = new List<string>();

      static void Main()
      {
         ReadInput();
         ConvertInputToCommands();
         RunCommands();

         Console.WriteLine(output.ToString());
      }

      private static void RunCommands()
      {
         output.Clear(); //cleans the empty lines befor the input

         for (int i = 0; i < allCommands.Count; i++)
         {
            int allLoops = 1;
            string[] subCommands = allCommands[i].Split(new char[] { ')' },StringSplitOptions.RemoveEmptyEntries);
            foreach (var command in subCommands)
            {
               string currentCommand = command.TrimStart();

               if (currentCommand.StartsWith("EXIT"))
               {
                  return;
               }
               else if (currentCommand.StartsWith("PRINT"))
               {
                  int paramsStart = currentCommand.IndexOf("(") + 1;
                  string content = currentCommand.Substring(paramsStart);
                  
                  for (int j = 0; j < allLoops; j++)
                  {
                     output.Append(content);
                  }
               }
               else if (currentCommand.StartsWith("FOR"))
               {
                  int paramsStart = currentCommand.IndexOf("(") + 1;
                  string allParams = currentCommand.Substring(paramsStart);

                  if (allParams.Contains(","))
                  {
                     string[] loopParams = allParams.Split(',');

                     int a = int.Parse(loopParams[0]);
                     int b = int.Parse(loopParams[1]);

                     allLoops = allLoops * (b - a + 1);
                  }
                  else
                  {
                     int value = int.Parse(allParams);

                     allLoops = allLoops * value;

                  }
               }
            }
         }
      }

      private static void ConvertInputToCommands()
      {
         string allInput = output.ToString();
         output.Clear();

         foreach (var symbol in allInput)
         {
            output.Append(symbol);
            if (symbol == ';')
            {
               allCommands.Add(output.ToString());
               output.Clear();
            }
         }
      }

      private static void ReadInput()
      {
         while (true)
         {
            string line = Console.ReadLine();
            output.Append(line);
            if (line.Contains("EXIT;"))
            {
               break;
            }
         }
      }
   }
}
