using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input: ");
        int num=int.Parse(Console.ReadLine());
        int num1=0;
        int num2=1;
        
        System.Console.WriteLine($"Here is the Fibonacci series up to {num} terms : ");
        System.Console.Write($"{num1} ");
        System.Console.Write($"{num2} ");
        for(int i=0;i<num-2;i++)
        {
            int num3=num1+num2;
            System.Console.Write($"{num3} ");
            num1=num2;
            num2=num3;
        }
    }
}
