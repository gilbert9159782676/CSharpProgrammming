
using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number : ");
        int input=int.Parse(Console.ReadLine());

        for(int i=1;i<=input;i++)
        {
            for(int j=input-i;j>0;j--)
            {
                System.Console.Write(" ");
            }
            for(int k=1;k<=2*(i)-1;k++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        
    }
}
