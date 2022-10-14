using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        //Formula: 3.14* r2 h
        
        System.Console.Write("Input radius = ");
        double radius=double.Parse(Console.ReadLine());
        System.Console.Write("Height = ");
        double height=double.Parse(Console.ReadLine());
        double volume=3.14*Math.Pow(radius,2)*height;
        System.Console.WriteLine($"Volume : {volume} ");

        
        
    }
}
