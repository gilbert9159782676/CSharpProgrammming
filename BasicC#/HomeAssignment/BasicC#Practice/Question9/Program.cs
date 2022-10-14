using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input speed: ");
        int speed=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second: ");
        int second=int.Parse(Console.ReadLine());
        int distance= speed *second * 5/18;

        System.Console.WriteLine($"Output : {distance} Meters");
    }
}
