using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a number: ");  
        int num=int.Parse(Console.ReadLine());

        Fact(num);

        void Fact(int num)
        {
            int count=1;
            int result=1;
            while(count<=num)
            {
                result*=count;
                count++;
            }
            System.Console.WriteLine($"The factorial of the {num}! is  {result}");
        }
    }
}
