using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the month: ");
        string month=(Console.ReadLine()).ToUpper();
        
        if(month=="JANUARY" || month=="DECEMBER" || month=="FEBRUARY")
        {
            System.Console.WriteLine("winter");
        }
        else if(month=="MARCH" || month=="APRIL" || month=="MAY")
        {
            System.Console.WriteLine("spring");
        }
        else if(month=="JUNE" || month=="JULY" || month=="AUGUST")
        {
            System.Console.WriteLine("summer");
        }
        else if(month=="NOVEMBER" || month=="SEPTEMBER" || month=="OCTOBER")
        {
            System.Console.WriteLine("rainfall");
        }
    }
}
