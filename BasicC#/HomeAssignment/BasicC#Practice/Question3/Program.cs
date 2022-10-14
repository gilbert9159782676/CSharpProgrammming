using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the amount of celcius: ");
        double celcius=double.Parse(Console.ReadLine());
        double Kelvin=celcius+273.15;
        double Fahrenheit=(celcius * 9/5) + 32;
         
         System.Console.WriteLine($"Kelvin= {Kelvin}");
         System.Console.WriteLine($"Fahrenheit= {Fahrenheit}");
    }
}
