using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the month name : ");
        string month=Console.ReadLine().ToLower();
        System.Console.Write("Enter the leave taken in the month : ");
        int leave=int.Parse(Console.ReadLine());
        if(month=="january" ||month=="march"|| month=="may"|| month=="july" ||month=="august" ||month=="october" ||month=="december")
        {
            int res=(31-leave)*500;
            System.Console.WriteLine($"Total salary = {res}");

        }
        else if(month=="february"){
            int res=(28-leave)*500;
            System.Console.WriteLine($"Total salary = {res}");
        

        }
        else if(month=="april"|| month=="june" ||month=="september"|| month=="november")
        {
            int res=(30-leave)*500;
            System.Console.WriteLine($"Total salary = {res}");

        }

        

    }
}
