using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int[] integerList=new int[10];
        for(int i=0;i<10;i++)
        {
            System.Console.Write($"Enter the element{i}:");
            integerList[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Elements in array are : ");
        foreach(int num in integerList)
        {
            
            System.Console.Write($"{num} ");
        }
    }
}
