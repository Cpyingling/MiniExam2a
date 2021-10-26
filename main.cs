/*Author Charlie Yingling                                     Date 10/25/21

Create a C# app to prompt the user for the radius and height of a cylinder, and call method CylinderVolume 
*/
using System;

class Program {
  public static double CylinderVolume (double radi,double height) {
      return 3.14 * radi * radi * height;
  }

  public static void Main (string[] args) {
        Console.WriteLine("Enter Height of Cylinder:");
  double Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Radius of Cylinder:");
  double Radius = Convert.ToDouble(Console.ReadLine());
  double v = CylinderVolume(Height,Radius);
        Console.WriteLine("Volume: {0}", v);
  }
}