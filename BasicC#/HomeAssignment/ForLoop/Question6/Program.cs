using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the Number: ");
        int num=int.Parse(Console.ReadLine());
        
        for(int count=1;count<=num;count++){
            for (int sCount=1;sCount<=count;sCount++){
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
            
        }
    }
}
