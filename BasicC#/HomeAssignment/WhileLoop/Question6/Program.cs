using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        int number=1;
        System.Console.WriteLine("Odd numbers :");
        while(number<=100)
        {
            System.Console.Write($"{number} ");
            number+=2;
        }


        int number2=2;
        System.Console.WriteLine("\nEven numbers :");

        while(number2<=100)
        {
            System.Console.Write($"{number2} ");
            number2+=2;
        }

        
        int number3=2;
        int count=2;
        System.Console.WriteLine("\nPrime numbers :");
        bool result=true;
        while(number3<=100)
        {
            count=2;
            while(count<number3)
            {
                result=true;
                if(number3%count==0)
                {
                    result=false;
                    break;
                }
               
                count++;
                
            }
            if(result==true)
                {
                    System.Console.Write($"{number3} ");
                }
            number3++;
        }

    }
}
