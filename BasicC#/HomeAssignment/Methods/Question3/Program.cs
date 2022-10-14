using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number1: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the number2: ");
        int num2=int.Parse(Console.ReadLine());

        Swap(num1,num2);
        void Swap(int num1,int num2)
        {
            int temp=num1;
            num1=num2;
            num2=temp;
            System.Console.WriteLine($"num1={num1}");
            System.Console.WriteLine($"num2={num2}");
        }

    }
}
