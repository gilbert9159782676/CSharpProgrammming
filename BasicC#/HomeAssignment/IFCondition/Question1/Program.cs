using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        if (num%2==0)
        {
            System.Console.WriteLine($"{num} is an even integer");
        }
        else
        {
            System.Console.WriteLine($"{num} is an odd integer");
        }

    }
}