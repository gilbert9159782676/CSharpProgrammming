using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string : ");
        string input=Console.ReadLine();
        System.Console.WriteLine("The characters of the string in reverse are :");
        for(int index=input.Length-1;index>=0;index--)
        {
            System.Console.Write($"{input[index]} ");
        }
    }
}
