using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        bool result= true;
        for(int count=2;count<num;count++)
        {
            if(num%count==0)
            {
                System.Console.WriteLine($"{num} is not a prime number");
                result=false;
                break;
            }
        }
        if(num==1)
        {
            System.Console.WriteLine("1 is exception");
        }
        else if(result==true)
        {
            System.Console.WriteLine($"{num} is a prime number");
        }
        
    }
}
