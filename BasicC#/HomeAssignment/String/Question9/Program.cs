using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string input=Console.ReadLine();
        System.Console.Write("Enter the substring: ");
        string substring=Console.ReadLine();
        
        string[] stringArr=input.Split(" ");
        bool result=false;
        foreach(string var in stringArr)
        {
            if(substring==var)
            {
                System.Console.WriteLine("The substring exists in the string");
                result=true;
            }
        }
        if(result==false)
        {
            System.Console.WriteLine("The substring not exist in the string");
        }
    }
}

