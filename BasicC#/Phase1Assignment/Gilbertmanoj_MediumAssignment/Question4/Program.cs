using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter Lower limit: ");
        int lowerLimit=int.Parse(Console.ReadLine());
        System.Console.Write("Enter Upper limit: ");
        int upperLimit=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Armstrong number between {lowerLimit} to {upperLimit} are:");
        
        for(int num=lowerLimit;num<=upperLimit;num++){
                    int temp1=num;
                    int temp2=num;
                    int count=0;
                    while(temp1>0)
                    {
                        temp1/=10;
                        count++;
                    }
                    double sum=0;
                    while(temp2>0)
                    {
                        int rem=temp2%10;
                        sum+=Math.Pow(rem,count);
                        temp2/=10;
                    }
                    if(num==sum)
                    {
                        System.Console.Write($"{num} ");
                    }
        }

    }
}
