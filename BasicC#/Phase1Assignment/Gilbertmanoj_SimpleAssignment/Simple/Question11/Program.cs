using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter X: ");
        int x=int.Parse(Console.ReadLine());
        System.Console.Write("Enter Y: ");
        int y=int.Parse(Console.ReadLine());
        int result=1;
        for(int i=0;i<y;i++){
            result*=x;
        }
        System.Console.WriteLine($"The solution is: {result}");
    }
}
