using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        for(int i=1;i<=20;i++)
        {
            System.Console.WriteLine($"{num}*{i}={num*i}");
        }
    }
}
