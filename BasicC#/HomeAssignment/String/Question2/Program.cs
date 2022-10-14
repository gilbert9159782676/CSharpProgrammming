using System;
namespace question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string : ");
        string input=Console.ReadLine();
        System.Console.WriteLine("The characters of the string are :");
        foreach(char var in input)
        {
            System.Console.Write($"{var} ");
        }
    }
}
