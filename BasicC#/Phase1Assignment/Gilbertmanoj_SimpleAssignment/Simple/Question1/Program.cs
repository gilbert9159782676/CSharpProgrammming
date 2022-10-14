using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the inch: ");
        double inch=double.Parse(Console.ReadLine());
        double cm=inch*2.54;
        System.Console.WriteLine($"CM : {cm}");
    }
}
