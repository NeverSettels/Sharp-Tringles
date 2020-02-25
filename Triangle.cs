using System;
using System.Collections.Generic;

public class Triangle
{
  public static string TypeOfTriangle(int side1, int side2, int side3)
  {
    if ((side1 + side2) < side3 || (side2 + side3) < side1 || (side1 + side3) < side2)
    {
      return "not-a-triangle";
    }   
    else if ((side1 + side2) >= side3)
    {
      if (side1 ==  side2 && side2 == side3)
      {
        return "equilateral";
      } 
      else if (side1 ==  side2 ||  side2 == side3 || side3 == side1)
      {
        return "isosceles";
      } 
      else 
      {
        return "scalene";
      }
    } 
    else if ( side2 + side3 > side1)
    {
      if (side1 ==  side2 && side2 == side3)
      {
        return "equilateral";
      } 
      else if (side1 ==  side2 ||  side2 == side3 || side3 == side1)
      {
        return "isosceles";
      } 
      else
      {
        return "scalene";
      }
    } 
    else if (side3 + side1 >  side2)
    {
      if (side1 ==  side2 && side2 == side3)
      {
        return "equilateral";
      } 
      else if (side1 ==  side2 ||  side2 == side3 || side3 == side1) 
      {
        return "isosceles";
      } 
      else 
      {
        return "scalene";
      }
    }
    else
    {
      return "not a triangle";
    }
  }

  public static void Main ()
  {
    Console.WriteLine("Please enter 3 sides, and we'll tell you if its a triangele, and what kind");
    string side1Str = Console.ReadLine();
    string side2Str = Console.ReadLine();
    string side3Str = Console.ReadLine();

    int side1 = int.Parse(side1Str);
    int side2 = int.Parse(side2Str);
    int side3 = int.Parse(side3Str);

    string result = TypeOfTriangle(side1, side2, side3);
    Console.WriteLine(result);
  }
}