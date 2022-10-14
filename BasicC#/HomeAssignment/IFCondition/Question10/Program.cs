using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the password: ");
        string password=Console.ReadLine();
        string defaultPassword="HiTeam";
        
        if(password==defaultPassword)
        {
            System.Console.WriteLine("Right password");
        }
        else{
            System.Console.WriteLine("Wrong password");
        }
    }
}
