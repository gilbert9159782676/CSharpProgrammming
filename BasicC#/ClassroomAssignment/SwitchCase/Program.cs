using System;
namespace SwichCase;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the First number: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second number: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the operator: ");
        char oper=char.Parse(Console.ReadLine());

        switch(oper)
        {
            case '+':
            {
                System.Console.WriteLine($"Result = {num1+num2}");
                break;
            }
            case '-':
            {
                System.Console.WriteLine($"Result = {num1-num2}");
                break;
            }
            case '*':
            {
                System.Console.WriteLine($"Result = {num1*num2}");
                break;
            }
            case '/':
            {
                System.Console.WriteLine($"Result = {num1/num2}");
                break;
            }
            case '%':
            {
                System.Console.WriteLine($"Result = {num1%num2}");
                break;
            }
            default:
            {
                System.Console.WriteLine("Operation Invalid");
                break;
            }
        }
    }
}
