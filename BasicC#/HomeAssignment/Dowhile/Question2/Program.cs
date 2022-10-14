using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        
        int sum=0;
        int input=0;
        do
        {
            System.Console.Write("Enter the number: ");
            input=int.Parse(Console.ReadLine());
            if(input>0)
            {
             
                sum+=input;
            }
        }while(input>=0);
        System.Console.WriteLine($"The sum is {sum}");
    }
}