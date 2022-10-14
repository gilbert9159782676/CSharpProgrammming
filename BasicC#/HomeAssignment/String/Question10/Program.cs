using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        string defaultUseName="user";
        string defaultPassword="pass";
        System.Console.Write("Enter the username: ");
        string username=Console.ReadLine();
        System.Console.Write("Enter the password: ");
        string password=Console.ReadLine();
        
        if(username==defaultUseName && password==defaultPassword)
        {
            System.Console.WriteLine("Password entered successfully!");
        }
        else
        {
            System.Console.WriteLine("Incorrect password!");
        }
    }
}

