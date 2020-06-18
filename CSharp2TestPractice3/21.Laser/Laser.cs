//http://my.telerikacademy.com/courses/Courses/Details/219

//http://bgcoder.com/Contests/54/CSharp-Part-2-2012-2013-5-Feb-2013

//You are given a rectangular cuboid of size W(width), H(height) and D(depth) consisting of W* H * D cubes.All cubes have coordinates, corresponding to their position, starting from(1, 1, 1) – the coordinates of the "left, lower, near" cube and going to(W, H, D) – the coordinates of the "right, upper, far" cube.
//Adjacent cubes we will call any cubes which share a common wall, edge or vertex.So, any cube in the cuboid has 26 (8 + 9 + 9) adjacent cubes, except if it is on the edge or wall of the cuboid(then it has less).  
//Let’s say we go inside one of the cubes in the cuboid(which is not on the side, or on the edge of the cube) and shoot a laser from it into one of the adjacent cubes.We can define the direction of the shot with a 3D vector, which has only 1, -1 or 0 as its coordinate values.So, for example if we want to shoot a laser straight up, that direction will be (0, 1, 0), if we want to shoot it straight down, the direction will be(0, -1, 0), if we want to shoot it forwards and up the direction will be(0, 1, 1) and if we want to shoot it left, forward and up the direction will be(-1, 1, 1). We have a total of 26 possible directions(the number of adjacent cubes).
//When the laser passes through a cube, it burns it and it cannot pass through it again.Furthermore, if the laser reaches the wall of the cuboid (that is, a cube which is on the wall), it burns the cube there and reflects back into the cuboid, continuing to burn cubes it passes through.The reflection happens according to the laws of light reflection.Basically, the component of the direction vector, which would cause the laser to leave the cuboid, becomes the opposite number. So if a laser is moving in direction “right” (1, 0, 0), once it reaches the right wall of the cube it will reflect back, moving in direction “left(-1, 0, 0), but, in this case, that will cause it to visit an already burnt cube, so the laser will stop there.
//Furthermore, all cubes on the edges (red green and blue cubes on the picture) of our cuboid are burned to begin with. So a laser will always stop before reaching the edge, because it cannot go into the edge cubes.

//Write a program, which by given the width, height and depth of a cuboid, along with the coordinates of the cube from which the laser is shot and the direction of the shot, determines the last position the laser can reach in the cube. 
//Note: the starting position is burned during the shot, so it cannot be the answer (unless the laser travels into no other cubes, which can only happen if the next cube it should visit is an edge cube). The edges are burned by default, so no cube on the edge can be an answer either.
//Input
//The input data should be read from the console.
//On the first line of the input there will be the numbers W, H, D, separated by whitespaces – the width, height and depth of the cuboid
//On the next line there will be the numbers startW, startH, startD, separated by whitespaces – the width, height and depth of the cube, from which the laser is shot.
//On the third line there will be the numbers dirW, dirH, dirD, separated by whitespaces – defining the direction, in which the laser is shot.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//On the only line of the output you should print exactly 3 numbers, separated by whitespaces – the width, height and depth of the last cube the laser will visit.
//Constraints
//•	W, H, D, startW, startH, startD, dirW, dirH and dirD will all be integers
//•	4 < W, H, D < 100
//•	1 < startW, startH, startD < W, H, D
//•	Each of the numbers dirW, dirH, dirD can only have the values -1, 1 or 0
//•	Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
//Examples
//Sample input             Sample output
//5 10 5
//2 6 3
//1 0 1
//                         	1 6 2


using System;


namespace _21.Laser
{
    class Laser
    {
        static void Main()
        {
            int[] dims = GetThreeNumbersFromConsole();
            int[] pos = GetThreeNumbersFromConsole();
            int[] vect = GetThreeNumbersFromConsole();

            bool[,,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1];

            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;
                int[] newPos = new int[3];


                //pos: (2, 2, 2)
                //vect: (1, 0, -1)
                //newPos: (3, 2, 1)
                for (int i = 0; i < 3; i++)
                {
                    newPos[i] = pos[i] + vect[i];
                }

                if (visited[newPos[0], newPos[1], newPos[2]] || HowManyIndixesAreLimit(newPos, dims) >= 2)
                {
                    //next position is visitted
                    Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                    return;
                }

                if (HowManyIndixesAreLimit(newPos, dims) == 1)
                {
                    //there is a wall
                    ReverseComponent(newPos, vect, dims);
                }

                for (int i = 0; i < 3; i++)
                {
                    pos[i] = newPos[i];
                }

            }

        }


        static void ReverseComponent(int[] newPos, int[] vect, int[] dims)
        {
            for (int i = 0; i < 3; i++)
            {
                if (newPos[i] == 1 && vect[i] == -1)
                {
                    vect[i] *= -1;
                }
                else if (newPos[i] == dims[i] && vect[i] == 1)
                {
                    vect[i] *= -1;
                }

            }

        }



        static int HowManyIndixesAreLimit(int[] pos, int[] dims)
        {
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 1 || pos[i] == dims[i])
                {
                    count++;
                }
            }
            return count;
        }

        //Read the Input
        static int[] GetThreeNumbersFromConsole()
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            //return split.Select(s => int.Parse(s)).ToArray();

            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(split[i]);

            }
            return array;            
        }
    }
}
