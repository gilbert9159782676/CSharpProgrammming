using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Input1: ");
        int input1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the Input2: ");
        int input2=int.Parse(Console.ReadLine());

        Addition(input1,input2);
        Subtraction(input1,input2);
        Multiplication(input1,input2);
        Division(input1,input2);

        void Addition(int input1,int input2)
        {
            System.Console.WriteLine($"Addition : {input1+input2}");
        }
        void Subtraction(int input1,int input2)
        {
            System.Console.WriteLine($"Subtraction : {input1-input2}");
        }
        void Multiplication(int input1,int input2)
        {
            System.Console.WriteLine($"Multiplication : {input1*input2}");
        }
        void Division(int input1,int input2)
        {
            System.Console.WriteLine($"Division : {input1/input2}");
        }
    }
}