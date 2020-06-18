using System;

//Write program that calculates the surface of a triangle by given two sides and an angle between them.

//Input
//•On the first line you will receive the length of the first side of the triangle
//•On the second line you will receive the length of the second side of the triangle
//•On the third line you will receive the angle between the given sides ◦Angle is given in degrees


//Output
//•Print the surface of the rectangle with two digits of precision

//Constraints
//•Input data describes a valid triangle
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input: 10
         //7
         //25  

//Output:  14.79 





namespace _06.TriangleSurfaceByTwoSidesAndAnAngle
{
   class TriangleSurfaceByTwoSidesAndAnAngle
   {
      static double AreaBySidesAndAngle(double sideA, double sideB, double angle)
      {
         return (sideA * sideB * Math.Sin(Math.PI * angle / 180)) / 2;
      }
      static void Main()
      {
         double sideA = double.Parse(Console.ReadLine());
         double sideB = double.Parse(Console.ReadLine());
         double angle = double.Parse(Console.ReadLine());

         double area;
         area = AreaBySidesAndAngle(sideA, sideB, angle);

         Console.WriteLine("{0:F2}", area);
      }
   }
}
