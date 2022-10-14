using System;
namespace Question5;
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
        int oddCount=0;
        int evenCount=0;
        foreach(int num in integerList){
            if (num%2!=0)
            {
                oddCount++;
            }
            else{
                evenCount++;
            }
        }
        int[] oddArrays=new int[oddCount];
        int[] evenArrays=new int[evenCount];
        int k=0;
        foreach(int num in integerList){
            if (num%2!=0)
            {
                oddArrays[k]=num;
                k++;
            }
            
        }
        int j=0;
        foreach(int num in integerList){
            if (num%2==0)
            {
                evenArrays[j]=num;
                j++;
            }
            
        }
        System.Console.WriteLine("The Even elements are: ");
        foreach(int even in evenArrays)
        {
            System.Console.Write($"{even} ");
        }
        System.Console.WriteLine("\nThe odd elements are: ");
        foreach(int odd in oddArrays)
        {
            System.Console.Write($"{odd} ");
        }
        
    }
}
