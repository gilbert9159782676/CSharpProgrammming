using System;
namespace String;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Main string: ");
        string mainString=Console.ReadLine();
        System.Console.Write("String to be selected: ");
        string searchString=Console.ReadLine();
        
        string[] countString=mainString.Split(new string[] {searchString},StringSplitOptions.None);
       
        System.Console.WriteLine($"String serached count is {countString.Length-1}");
    }
}
