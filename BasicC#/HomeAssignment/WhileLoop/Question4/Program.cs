using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input: ");
        int num;
        bool result=int.TryParse(Console.ReadLine(),out num);

        while((!result) || (num>5))
        {
            System.Console.Write("invalid input enter again: ");
            result=int.TryParse(Console.ReadLine(),out num);
        }
        
        System.Console.WriteLine("valid input");


    }
}
