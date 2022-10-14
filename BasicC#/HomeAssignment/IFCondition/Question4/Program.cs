using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number1: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the number2: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the number3: ");
        int num3=int.Parse(Console.ReadLine());

        if (num1>num2 && num1>num3)
        {
            System.Console.WriteLine($"The 1st number is the greatest among three");
        }
        else if(num2>num1 && num2>num3)
        {
            System.Console.WriteLine($"The 2nd number is the greatest among three");
        }
        else if(num3>num2 && num3>num1){
            System.Console.WriteLine($"The 3rd number is the greatest among three");
        }
        else{
            System.Console.WriteLine("please enter three diffrent inputs");
        }
    }
}
