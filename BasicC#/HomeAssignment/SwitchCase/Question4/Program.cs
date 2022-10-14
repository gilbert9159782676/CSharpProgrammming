using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        
        System.Console.Write("Enter the first integer: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second integer: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the operation\n1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.");
        int oper=int.Parse(Console.ReadLine());
        switch(oper){
            case 1:
            {
                System.Console.WriteLine($"Output is: {num1+num2}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"Output is: {num1-num2}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"Output is: {num1*num2}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"Output is: {num1/num2}");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exit successfully");
                break;
            }
            default:
            {
                System.Console.WriteLine("Wrong Input");
                break;
            }
        }
    }
}
