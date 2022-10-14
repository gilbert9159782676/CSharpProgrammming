using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        double sum=0;
        for(int num=1;num<=10;num++)
        {
            sum+=num;
        }
        double average=sum/10;
        System.Console.WriteLine($"Sum = {sum}");
        System.Console.WriteLine($"Average = {average}");

    }
}
