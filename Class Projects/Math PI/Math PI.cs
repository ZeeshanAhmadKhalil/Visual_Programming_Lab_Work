using System;
class Program
{
    static void Main()
    {
        int diameter_of_circle = 21;
        double radius_of_circle = diameter_of_circle / 2;
        double circumference_of_circle = 2*Math.PI*radius_of_circle;
        double area_of_circle = Math.PI * Math.Pow(radius_of_circle, 2);
        Console.WriteLine("Diameter of Circle="+diameter_of_circle);
        Console.WriteLine("Radius Of Circle=" + radius_of_circle);
        Console.WriteLine("Circumference Of Circle=" + circumference_of_circle);
        Console.WriteLine("Area Of Circle=" + area_of_circle);
    }
}
