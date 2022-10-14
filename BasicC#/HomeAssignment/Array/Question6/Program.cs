using System;
namespace Question6;
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
        for(int num=0;num<integerList.Length;num++)
        {
            for(int num1=num+1;num1<integerList.Length;num1++)
            {
                if(integerList[num]>integerList[num1])
                {
                    int temp=integerList[num];
                    integerList[num]=integerList[num1];
                    integerList[num1]=temp;

                }


            }
        }
        System.Console.WriteLine("Elements of array in sorted ascending order: ");
        for(int k=0;k<integerList.Length;k++)
        {
            System.Console.Write($"{integerList[k]} ");
        }
        
    }
}
