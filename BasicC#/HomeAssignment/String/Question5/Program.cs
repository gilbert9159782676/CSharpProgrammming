using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the 1st string : ");
        string input1=Console.ReadLine().ToLower();
        System.Console.Write("Input the 2nd string : ");
        string input2=Console.ReadLine().ToLower();
        
        if(input1==input2)
        {
            System.Console.WriteLine("The length of both strings are equal and also, both strings are equal");
        }
        else{
            System.Console.WriteLine("Not equal");
        }
    }
}
