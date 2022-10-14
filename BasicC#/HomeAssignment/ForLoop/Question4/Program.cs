using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        for(int counter=1;counter<=10;counter++)
        {
            System.Console.WriteLine($"{num} * {counter} = {num*counter}");
        }
    }
}
