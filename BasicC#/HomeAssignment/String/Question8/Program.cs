using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string inputString=Console.ReadLine();
        System.Console.Write("Input the position to start extraction : ");
        int start=int.Parse(Console.ReadLine());
        System.Console.Write("Input the length of substring : ");
        int count=int.Parse(Console.ReadLine());

        for(int i=start-1;i<=start-1+count;i++) 
        {
            System.Console.Write(inputString[i]);
        }
        
    }
}
