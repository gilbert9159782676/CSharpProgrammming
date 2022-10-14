using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        string num=Console.ReadLine();
        int length=num.Length;
        int input=int.Parse(num);
        int temp=input;
        double sum=0;
        for(int i=1;i<=length;i++)
        {
            int rem=input%10;
            sum=sum+(Math.Pow(rem,length));
            input=input/10;

        }
        
        if(temp==sum)
        {
            System.Console.WriteLine($"{temp} is an Amstrong number.");
        } 
        else
        {
            System.Console.WriteLine($"{temp} is not an amstrong number");
        }

       
        
    }
}
