using System;
namespace Question14;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        for(int i=1;i<=num;i++)
        {
            for(int j=1;j<=i;j++)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
    
        }
        
    }
}
