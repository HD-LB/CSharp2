using System;

//Write program that calculates the surface of a triangle by given its three sides.

//Input
//•On the first line you will receive the length of the first side of the triangle
//•On the second line you will receive the length of the second side of the triangle
//•On the third line you will receive the length of the third side of the triangle

//Output
//•Print the surface of the rectangle with two digits of precision

//Constraints
//•Input data describes a valid triangle
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:  //11
          //12
          //13

//Output: 61.48 





namespace _05.TriangleSurfaceByThreeSides
{
   class TriangleSurfaceByThreeSides
   {

      static double AreaByThreeSides(double sideA, double sideB, double sideC)
      {
         double s = (sideA + sideB + sideC) / 2;
         return Math.Sqrt(s * ((s - sideA)) * (s - sideB) * (s - sideC));
      }
      static void Main()
      {
         double sideA = double.Parse(Console.ReadLine());
         double sideB = double.Parse(Console.ReadLine());
         double sideC = double.Parse(Console.ReadLine());

         double area;

         area = AreaByThreeSides(sideA, sideB, sideC);

         Console.WriteLine("{0:F2}", area);
      }
   }
}
