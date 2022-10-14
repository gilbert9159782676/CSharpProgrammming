using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the number of elements to store in the array: ");
        int limit=int.Parse(Console.ReadLine());

        int[] integerList=new int[limit];
        int sum=0;
        System.Console.Write($"Input {limit} number of elements in the array : \n");
        for(int i=0;i<limit;i++)
        {
            System.Console.Write($"Enter the element - {i} : ");
            int input=int.Parse(Console.ReadLine());
            sum+=input;
            
            
        }
        System.Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
    }
}