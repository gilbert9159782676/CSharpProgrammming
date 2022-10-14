using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int input=int.Parse(Console.ReadLine());
        double sum=0;
        double value;
        for(int i=0;i<=input;i++)
        {
            value=Math.Pow(2,i)/Fact(i);
            sum+=value;
        }

        
        int Fact(int num)
        {
            int finalAnswer=1;
            for(int j=1;j<=num;j++)
            {
                finalAnswer*=j;
            }
            return finalAnswer;
        }

        System.Console.WriteLine($"Output: {sum}");
    }
}
