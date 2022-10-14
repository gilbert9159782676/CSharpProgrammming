using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your name: ");
        String name=Console.ReadLine();

        // concatenation method
        System.Console.WriteLine("Hello: "+ name);

        //Placeholder method
        System.Console.WriteLine("Hello: {0} ",name);

        //Interpolation method
        System.Console.WriteLine($"Hello: {name}");
    }
}