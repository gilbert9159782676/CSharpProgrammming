using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number:");
        int num=int.Parse(Console.ReadLine());
        int num1=0;
        int num2=1;
        int num3;
        Fibonacci(num);

        void Fibonacci(int num)
        {
            System.Console.Write($"{num1} ");
            System.Console.Write($"{num2} ");
            int count=0;
            while(count<num-2)
            {
                num3=num1+num2;
                System.Console.Write($"{num3} ");
                num1=num2;
                num2=num3;
                count++;
            }
        }

    }
}
