using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        double result=0;
        for(int num=1;num<100;num++)
        {
            if(num%2!=0)
            {
                result+=Math.Pow(num,2);
            }
        
        }
        System.Console.WriteLine($"Sum of square of given odd values range 1- 99 : {result}");
    }
}
