using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the count: ");
        int count=int.Parse(Console.ReadLine());
        int initial=1;
        double sum=0;
        while(initial<=count)
        {
            System.Console.Write($"Enter the Number{initial} : ");
            int num=int.Parse(Console.ReadLine());
            sum= sum+ Math.Pow(num,2);
            initial++;
        }
        System.Console.WriteLine($"Output: {sum}");
    }
}
