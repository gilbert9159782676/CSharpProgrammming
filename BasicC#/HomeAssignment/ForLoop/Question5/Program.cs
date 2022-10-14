using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Limit:");
        int limit=int.Parse(Console.ReadLine());
        int count=1;
        for(int i=1;i<=limit;i++)
        {
            System.Console.Write($"{count} ");
            count+=2;
        }
    }
}
