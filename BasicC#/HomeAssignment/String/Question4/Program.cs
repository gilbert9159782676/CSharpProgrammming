using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the string : ");
        string input=Console.ReadLine().ToLower();

        string[] strArr=input.Split(" ");

        int count=0;
        foreach(string var in strArr)
        {
            count++;
        }

        System.Console.WriteLine($"Total number of words in the string is : {count}");
        
        
    }
}
