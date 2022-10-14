using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        int sum=0;
        while(num!=0)
        {
            int rem=num%10;
            sum+=rem;
            num=num/10;
            
            
        }
        System.Console.WriteLine(sum);
    }
}
