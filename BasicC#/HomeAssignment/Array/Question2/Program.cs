using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the number of elements to store in the array: ");
        int limit=int.Parse(Console.ReadLine());

        int[] integerList=new int[limit];
        System.Console.Write($"Input {limit} number of elements in the array : \n");
        for(int i=0;i<limit;i++)
        {
            System.Console.Write($"Enter the element - {i} : ");
            integerList[i]=int.Parse(Console.ReadLine());
            
        }
        System.Console.Write("The values store into the array are : ");
         for(int i=0;i<limit;i++)
        {
            System.Console.Write($"{integerList[i]} ");
            
            
        }
        System.Console.Write("\nThe values store into the array in reverse are : ");
        for(int j=limit-1;j>=0;j--)
        {
            System.Console.Write($"{integerList[j]} ");
        }
    }
}
