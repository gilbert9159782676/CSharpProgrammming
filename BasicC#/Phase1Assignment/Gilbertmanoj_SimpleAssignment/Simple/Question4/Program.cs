using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the value of the INR : ");
        double inr=double.Parse(Console.ReadLine());
        
        System.Console.WriteLine($"USD = {0.0122*inr}");
        System.Console.WriteLine($"EUR = {0.0127*inr}");
        System.Console.WriteLine($"CNY = {0.0879*inr}");
        
    }
}
