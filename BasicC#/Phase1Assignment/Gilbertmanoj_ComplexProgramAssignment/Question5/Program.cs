using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the date-1 dd/MM/yyyy HH:mm:ss format: ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null);
        System.Console.Write("Enter the date-2 dd/MM/yyyy HH:mm:ss format: ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm:ss", null);

        TimeSpan diffrenece=date1-date2;
        System.Console.WriteLine("The difference between two days: ");
        System.Console.WriteLine(diffrenece.ToString(@"dd"));
    }
}

