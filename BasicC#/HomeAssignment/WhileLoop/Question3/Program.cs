using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input: ");
        int count=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Here is the Fibonacci series upto to {count} terms :");
        int num1=0;
        int num2=1;
        System.Console.Write($"{num1} ");
        System.Console.Write($"{num2} ");
        int i=1;
        while(i<=count-2)
        {
            int num3=num1+num2;
            System.Console.Write($"{num3} ");
            num1=num2;
            num2=num3;
            i++;
        }

    }
}
