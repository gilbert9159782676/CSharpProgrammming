using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the year: ");
        int year=int.Parse(Console.ReadLine());
        if (year%4==0)
        {
            if(year%100==0){
                if(year%400==0)
                {
                    System.Console.WriteLine($"{year} is a leap year.");
                }
                else{
                    System.Console.WriteLine($"{year} is not a leap year.");
                }
            }
            else{
                System.Console.WriteLine($"{year} is a leap year.");
            }

        }
        else{
            System.Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
