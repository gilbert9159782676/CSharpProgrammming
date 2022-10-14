using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number:");
        int num=int.Parse(Console.ReadLine());

        PrimeNumber(num);
        
        void PrimeNumber(int num)
        {
            bool result=true;
            for(int count=2;count<num;count++)
            {
                if(num%count==0)
                {
                    System.Console.WriteLine("Not a prime number");
                    result=false;
                    break;
                }
            }
            if(result==true)
            {
                System.Console.WriteLine("It is a prime number");
            }
        }
    }
}
