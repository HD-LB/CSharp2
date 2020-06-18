//http://bgcoder.com/Contests/94/CSharp-Part-2-2013-2014-14-Sept-2013-Morning

//http://my.telerikacademy.com/courses/Courses/Details/219

//You are implementing a 3D version of the game Tron.If you are not familiar with the standard 2D version, it's a simple reaction game where players race on a grid, leaving colored trails behind them; any player who touches the trails is eliminated, and the last player alive is the winner.

//In the example, the two players start at points A and B respectively, moving on the grid and turning left and right, trying to surround each other.In point C, the red player crashes into the blue player's trail and loses the game.

//Tron 3D is similar, with the players racing on the surface of a 3D cube instead of inside a rectangle.

//There are two players, starting from the centers of two opposing walls of the cube, and turned in the same direction (towards one another). They move on a grid on the surface, and in every game cycle, they move one position in their current direction; before every move, they can turn left or right(turning is instant and doesn’t count as taking a cycle of game time).  

//In the example, the two players start at the centers of the front and back faces; they race on several walls of the cube, until the red player surrounds the blue player, and the blue player crashes in point D.
//Additional rules for movement:
//•	two of the walls of the cube are forbidden – а player who tries to move on one of these walls crashes and loses the game; the forbidden walls are opposite one another(on the picture they are marked with diagonal lines);
//•	when a player reaches an edge of the cube, he continues moving on the next wall, in the same direction(see point A on the example);
//•	a player can move on the edge of the cube(see segment B-C); when he reaches a corner of the cube, he must turn left or right(see point C).

//The game ends when one or both of the players crash.If both players crash on the same game cycle, the game is a draw; otherwise, the one who didn't crash wins. Your program will read a sequence of moves from the console, and determine the winner and the distance between the start and endpoint of the red player, along the grid (in this case, 8 – 4 down, and 4 along the bottom edge).
//Input
//The input data should be read from the console.On the first line, you will read three integers - X, Y and Z - representing the dimensions of the cube. X and Y represent the dimensions of the walls on which the players start, Y and Z are the dimensions of the forbidden walls, and X and Y are the dimensions of the other two walls. The players start in the center of the two opposite X* Y walls, and move in the direction of edge X (towards each other; see example input 2 below).
//On the second and third line you will read two strings of characters representing the motion of the red and blue players respectively.The motion is represented as a string of M, L and R characters, where M means "move without turning, L means "turn left", and R means "turn right".
//The input data will be correct and there is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the first output line you should print “RED”, “BLUE” or “DRAW”, depending on who won the game.
//On the second line, print the distance between the start and end points of the red player, measured along the playing grid, as an integer (if the red player crashes into a forbidden wall, his final position is the point where he crashed).
//Constraints
//•	The numbers X, Y and Z are positive even integers in the range[2…50].
//•	The motion strings will be between 2 and 120 characters long (only characters M, L and R).
//•	The length of the motion strings will be long enough to finish the game.
//•	Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
//Examples
//Example input (example on picture)            Example output
//8 4 6
//MMLMMMMRMRMMLMMRMMRMLMMRMMRMLMMLMMMLMMM
//LMMMMRMRMMMLMMRMMMMLMLMMMMRMLMMRMMMMRMM          RED
//                                                  8

//Example input(players move without turning and crash into each other)  Example output
//4 2 4
//MMMM
//MMMM  DRAW
//                                                                            3


namespace _03.Tron3D
{

   using System;
   using System.Linq;

   class Tron3D
   {
      static int oldX, oldY, oldZ;//Global for the whole Method
      static string redMoves, blueMoves;
      static int X, Y; //the coordinates of the cube
      static bool[,] used;
      static int currentRedX;
      static int currentRedY;
      static int currentBlueX;
      static int currentBlueY;
      static int redDirection;
      static int blueDirection;



      //Directions:
      //0 -> Right
      //1 -> Down
      //2 -> Left
      //3 -> Up
      //4 -> 0 (%)
      //Rotate Right -> direction++
      //Roteta Left -> direction--

      static void Main()
      {

         ReadInput();

         X = oldX;
         Y = oldY + oldY + oldY + oldZ;

         used = new bool[X + 1, Y];

         //Start position of Red
         currentRedX = oldX / 2;
         currentRedY = oldY / 2;

         //Start position of Blue
         currentBlueX = oldX / 2;
         currentBlueY = oldY + oldZ + (oldY / 2);

         redDirection = 0; //right
         blueDirection = 2; //left

         var redIndex = 0;
         var blueIndex = 0;

         //MMLMMMMRMRMMLMMRMMRMLMMRMMRMLMMLMMMLMMM //1.Player Moves
         //LMMMMRMRMMMLMMRMMMMLMLMMMMRMLMMRMMMMRMM  //2.Palyer Moves

         while (true)
         {
            #region Move Red
            int newRedX = currentRedX;
            int newRedY = currentRedY;

            while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
            {
               if (redMoves[redIndex] == 'L')
               {
                  redDirection = RotateLeft(redDirection);
               }
               else if (redMoves[redIndex] == 'R')
               {
                  redDirection = RotateRight(redDirection);
               }

               redIndex++;

            }

            MovePlayer(ref newRedX, ref newRedY, redDirection);
            redIndex++;
            #endregion


            #region Move Blue

            int newBlueX = currentBlueX;
            int newBlueY = currentBlueY;

            while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
            {
               if (blueMoves[blueIndex] == 'L')
               {
                  blueDirection = RotateLeft(blueDirection);
               }
               else if (blueMoves[blueIndex] == 'R')
               {
                  blueDirection = RotateRight(blueDirection);
               }

               blueIndex++;

            }

            MovePlayer(ref newBlueX, ref newBlueY, blueDirection);
            blueIndex++;
            #endregion



            #region Fix Y Coordinates
            if (newRedY >= Y)
            {
               newRedY = 0;
            }

            if (newRedY < 0)
            {
               newRedY = Y - 1;
            }


            if (newBlueY >= Y)
            {
               newBlueY = 0;
            }

            if (newBlueY < 0)
            {
               newBlueY = Y - 1;
            }

            #endregion



            bool redLoses = Loses(newRedX, newRedY);
            bool blueLoses = Loses(newBlueX, newBlueY);


            if (redLoses && blueLoses)
            {
               Console.WriteLine("DRAW");
            }
            else if (redLoses)
            {
               Console.WriteLine("BLUE");
            }
            else if (blueLoses)
            {
               Console.WriteLine("RED");
            }


            

            currentRedX = newRedX;
            currentRedY = newRedY;
            currentBlueX = newBlueX;
            currentBlueY = newBlueY;


            if (redLoses || blueLoses)
            {
               int startRedX = oldX / 2;
               int startRedY = oldY / 2;

               int diffRedYLeft = startRedY + (Y - currentRedY - 1);
               int diffRedYRight = Math.Abs(currentRedY - startRedY); 


               int diffRedX = Math.Abs(currentRedX - startRedX);
               int diffRedY = Math.Min(diffRedYLeft, diffRedYRight);

               int diffRed = diffRedX - diffRedY;

               if (redLoses && blueLoses)
               {
                  Console.WriteLine(diffRed - 1); //the Players has clashed on the previous flield
               }
               else
               {
                  Console.WriteLine(diffRed);
               }
              
               break;
            }
            used[newRedX, newRedY] = true;
            used[newBlueX, newBlueY] = true;

         }

      }



      public static void ReadInput()
      {
         string xyzAsString = Console.ReadLine();
         var xyzStringParts = xyzAsString.Split(' ');
         oldX = int.Parse(xyzStringParts[0]);
         oldY = int.Parse(xyzStringParts[1]);
         oldZ = int.Parse(xyzStringParts[2]);

         var redMoves = Console.ReadLine();
         var blueMoves = Console.ReadLine();
      }



      static int RotateRight(int direction)
      {
         int newDirection = direction + 1;
         if (newDirection == 4)
         {
            newDirection = 0;
         }
         return newDirection;
      }


      static int RotateLeft(int direction)
      {
         int newDirection = direction - 1;
         if (newDirection == -1)
         {
            newDirection = 3;
         }
         return newDirection;
      }

      public static void MovePlayer(ref int currentX, ref int currentY, int direction)
      {
         if (direction == 0)
         {
            currentY++;
         }
         else if (direction == 1)
         {
            currentX++;
         }
         else if (direction == 2)
         {
            currentY--;
         }
         else if (direction == 3)
         {
            currentX--;
         }
      }


      public static bool Loses(int playerX, int playerY)
      {
         if (playerX < 0)
         {
            return true;//the Player has lost
         }

         if (playerX > X)
         {
            return true; //the Player has lost
         }

         if (used[playerX, playerY])
         {
            return true; //the Player has lost
         }
        
         return false;
      }






   }
}
