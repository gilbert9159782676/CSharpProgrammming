using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Input: ");
        int input=int.Parse(Console.ReadLine());
        int count=1;
        for(int i=1;i<=input;i++)
        {
            for (int j=1;j<=input-i;j++)
            {
                System.Console.Write(" ");
            }
            for (int k=1;k<=i;k++){
                System.Console.Write($"{count} ");
                count++;
            }
        System.Console.WriteLine();

        }
    }
}
