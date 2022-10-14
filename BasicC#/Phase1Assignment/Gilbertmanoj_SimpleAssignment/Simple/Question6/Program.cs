using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input : ");
        string input=Console.ReadLine();
        
        string defualt="s3cr3t!P@ssw0rd";
        if(defualt==input)
        {
            System.Console.WriteLine("Welcome");
        }
        else{
            System.Console.WriteLine("Wrong password!");
        }

        
    }
}
