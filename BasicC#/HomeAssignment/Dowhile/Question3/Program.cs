using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int count=0;
        System.Console.Write("Enter the limit: ");
        int limit=int.Parse(Console.ReadLine());
        int num1=0,num2=1;
        System.Console.Write($"{num1} ");
        System.Console.Write($"{num2} ");
        do
        {
            int num3=num1+num2;
            System.Console.Write($"{num3} ");
            num1=num2;
            num2=num3;
            count++;

        }while(count<limit-2);
    }
}
