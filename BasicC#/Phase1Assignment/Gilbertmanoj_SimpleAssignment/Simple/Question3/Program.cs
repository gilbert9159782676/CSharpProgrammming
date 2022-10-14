using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the celcius value: ");
        double celcius=double.Parse(Console.ReadLine());
        double fahrenheit=(celcius*(9/5))+32;
        System.Console.WriteLine($"Fahrenheit = {fahrenheit}");
    }
}
