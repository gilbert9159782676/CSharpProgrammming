using System;
namespace Datetime;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n");
        DateTime doy=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine($"The year is : {doy.Year}");
        System.Console.WriteLine($"The Month is : {doy.Month}");
        System.Console.WriteLine($"The Day is : {doy.Day}");
        System.Console.WriteLine($"The Hour is : {doy.Hour}");
        System.Console.WriteLine($"The Minute is : {doy.Minute}");
        System.Console.WriteLine($"The Second is : {doy.Second}");


        
        string format=doy.ToString("yyyy/MM/dd HH:mm:ss:tt");
        string[] splitTime=format.Split(new string[]{"/",":"," "},StringSplitOptions.None);
        System.Console.WriteLine("\n");
        for(int i=splitTime.Length-1;i>=0;i--)
        {
            System.Console.Write($"{splitTime[i]} ");
        }

        System.Console.WriteLine("\n");
        Console.WriteLine("\nEnter the time like this yyyy/MM/dd hh:mm:ss tt format: ");
        DateTime userInput = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null);
        Console.WriteLine(userInput.ToString("yyy/MM/dd"));
    }
}
