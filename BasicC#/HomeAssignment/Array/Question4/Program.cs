using System;
namespace Question4;
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
        int min=integerList[0];
        int max=integerList[0];

        foreach(int num in integerList)
        {
            if(num>max)
            {
                max=num;
            }
            if(num<min)
            {
                min=num;
            }
        }
        System.Console.WriteLine($"Maximum element is : {max}");
        System.Console.WriteLine($"Minimum element is : {min}");
    }
}
