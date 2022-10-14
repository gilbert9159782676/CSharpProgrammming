using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the input: ");
        int input=int.Parse(Console.ReadLine());
        int end=input+
        for(int i=1;i<=input;i++)
        {

            if(i==1 || i==input){
                for(int k=1;k<=input;k++)
                {
                    System.Console.Write("*");
                }
            }
            else if(i%2==0)
            {
                for(int j=1;j<=input;j++)
                {
                    System.Console.Write(" ");


                }
            }
            
            else
            {
                for(int l=1;l<=input;l++)
                {
                    if(l==1 || l==input)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
            }
            System.Console.WriteLine();
        }
    }
}

