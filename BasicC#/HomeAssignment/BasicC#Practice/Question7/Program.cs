using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the value a = ");
        int a=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the value b = ");
        int b=int.Parse(Console.ReadLine());
        int output= (a*a) + (b*b) + 2*a*b;
        System.Console.WriteLine($"Output : {output}");
    }
}
