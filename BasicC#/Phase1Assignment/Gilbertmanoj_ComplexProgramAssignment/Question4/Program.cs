using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input : ");
        string input=Console.ReadLine();
        char [] arrayChars = input.ToCharArray();
        for(int i=0;i<input.Length;i++)
        {
            for(int j=0;j<input.Length;j++)
            {
                if(arrayChars[i]==arrayChars[j] && i!=j)
                {
                    arrayChars[j]='0';
                }
            }
        }
       for(int j=0;j<arrayChars.Length;j++)
       {
        if(arrayChars[j]!='0'){
            System.Console.Write(arrayChars[j]);
        }
       }
       

        

        
    }
}

