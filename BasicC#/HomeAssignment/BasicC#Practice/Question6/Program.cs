using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the price amount : ");
        int amount=int.Parse(Console.ReadLine());
        int tax= (amount*18)/100;
        int total=amount+tax;
        System.Console.WriteLine($"Total = {total}");
    }
}