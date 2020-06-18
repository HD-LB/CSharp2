//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/11/CSharp-Fundamentals-2011-2012-Part-2-Sample-Exam

//Mitko is the boss of a big software company called "MCPF" (Mitko Can't Play Football). MCPF has M employees with N different positions. Each position has a rating (number indicating how important the position is in the company's hierarchy). This rating will be positive integer number between 0 and 10000, inclusive.
//Your task is to write a program that orders Mitko's employees by their position. If two employees' positions are equally rated, then your program should order them lexicographically by their last(family) name.And if two employees have equally rated positions and same family names, your program must also sort them by their first name lexicographically.
//Input
//The input data should be read from the console.
//On the first line there will be the number N – the total number of positions in MCPF.On each of the next N lines there will be one job title and its rating, separated by dash ("-"). See the example below.
//On the very next line there will be the number M – the total number of employees in MCPF.On each of the next M lines there you will find one employee’s name (first name and last name separated by single space) and the employee's position. The employee's name and his position will be separated by dash("-"). See the example below.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//Your program must print exactly M lines, containing the employee's names, ordered by the rules explained above. Each name must be shown on a single line.
//Constraints
//•	N will be between 1 and 1000, inclusive.
//•	M will be between 1 and 1000, inclusive.
//•	The length of all position names, first and last names will be between 1 and 100, inclusive.
//•	Allowed working time for your program: 0.1 seconds.
//•	Allowed memory: 16 MB.
//Example
//Input example                                   Output example
//9
//Trainee - 0
//Owner - 100
//CEO - 98 
//Junior Developer - 30
//Unit Manager - 95
//Project Manager - 95
//Team Leader - 94
//Senior Developer - 50
//Developer - 40
//10
//Georgi Georgiev – Trainee
//Ademar Júnior – Unit Manager
//Dimitar Dimitrov – Owner
//Petar Atanasov – Project Manager
//Atanas Georgiev – Trainee
//Júnior Moraes – Trainee
//Ivan Bandalovski – Developer
//Apostol Popov – Developer
//Michel Platini – CEO
//Blagoy Makendzhiev - CEO                           Dimitar Dimitrov
//                                                   Blagoy Makendzhiev
//                                                   Michel Platini
//                                                   Petar Atanasov
//                                                   Ademar Junior
//                                                   Ivan Bandalovski
//                                                   Apostol Popov
//                                                   Atanas Georgiev
//                                                   Georgi Georgiev
//                                                   Junior Moraes



namespace _09.Employees
{
   using System;
   using System.Collections.Generic;
   using System.Linq;

   class Employee
   {
      public string FirstName { get; set; } //prop Tab+Tab

      public string LastName { get; set; }

      public int Rank { get; set; }

      public string Position { get; set; }
   }


   public class Employees
   {
      static void Main()
      {
         Dictionary<string, int> posAndRank = new Dictionary<string, int>();

         int numberOFPositions = int.Parse(Console.ReadLine());

         for (int i = 0; i < numberOFPositions; i++)
         {
            string line = Console.ReadLine();

            string[] rawInput = line.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            if (!posAndRank.ContainsKey(rawInput[0]))
            {
               posAndRank.Add(rawInput[0], int.Parse(rawInput[1]));
            }

         }

         int numberOfEmployees = int.Parse(Console.ReadLine());

         List<Employee> allWorkers = new List<Employee>();

         for (int i = 0; i < numberOfEmployees; i++)
         {
            string line = Console.ReadLine();
            string[] rawInput = line.Split(new string[] { " - "}, StringSplitOptions.RemoveEmptyEntries);

            Employee currentEmp = new Employee();

            string[] splitedName = rawInput[0].Split();
            currentEmp.FirstName = splitedName[0];
            currentEmp.LastName = splitedName[1];
            currentEmp.Position = rawInput[1];
            currentEmp.Rank = posAndRank[currentEmp.Position];

            allWorkers.Add(currentEmp);
         }

         var sortedWorkers = allWorkers
                             .OrderByDescending(em => em.Rank)
                             .ThenBy(em => em.LastName)
                             .ThenBy(em => em.FirstName);

         foreach (var worker in sortedWorkers)
         {
            Console.WriteLine("{0} {1}",worker.FirstName, worker.LastName);
         }
      }
   }
}
