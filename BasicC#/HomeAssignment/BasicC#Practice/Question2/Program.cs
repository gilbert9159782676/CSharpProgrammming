using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the first number: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.Write("Input the second number: ");
        int num2=int.Parse( Console.ReadLine());

        int add=num1+num2;
        int sep=num1-num2;
        int multiply=num1*num2;
        int divison=num1/num2;
        int modDiv=num1%num2;

        System.Console.WriteLine($"{num1} + {num2} = {add}");
        System.Console.WriteLine($"{num1} - {num2} = {sep}");
        System.Console.WriteLine($"{num1} * {num2} = {multiply}");
        System.Console.WriteLine($"{num1} / {num2} = {divison}");
        System.Console.WriteLine($"{num1} % {num2} = {modDiv}");

        
    }
}
