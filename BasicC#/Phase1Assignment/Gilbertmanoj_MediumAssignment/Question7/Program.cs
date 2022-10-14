using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("starting number = ");
        int startingNumber=int.Parse(Console.ReadLine());
        System.Console.Write("Difference = ");
        int difference=int.Parse(Console.ReadLine());
        System.Console.Write("Number of elements = ");
        int numOfElement=int.Parse(Console.ReadLine());

        int sum=startingNumber;
        for(int i=startingNumber;i<startingNumber+numOfElement;i++)
        {
            System.Console.Write($"{sum} ");
            sum+=difference;
        }

        
    }
}
