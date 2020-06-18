using System;
//Write program that calculates the surface of a triangle by given a side and an altitude to it.

//Input
//•On the first line you will receive the length of a side of the triangle
//•On the second line you will receive the altitude to that side

//Output
//•Print the surface of the rectangle with two digits of precision

//Constraints
//•Input data describes a valid triangle
//•Time limit: 0.1s
//•Memory limit: 16MB

//Sample tests


//Input:   //23.2
            //5

//Output:   58.00 






namespace _04.TriangleSurface
{
   class TriangleSurface
   {

      static double AreaByAltetudeAndHight(double altitude, double lenght)
      {
         return (altitude * lenght) / 2;
        
      }
      static void Main()
      {
         double altitude = double.Parse(Console.ReadLine());
         double lenght = double.Parse(Console.ReadLine());

         double area;
         area = AreaByAltetudeAndHight(altitude, lenght);

         Console.WriteLine("{0:F2}", area);
      }
   }
}
