using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("nameOne: ");
        string nameOne=Console.ReadLine();
        System.Console.Write("nameTwo: ");
        string nameTwo=Console.ReadLine();
        int stringLength=nameOne.Length;
        int count=0;
        if(nameOne.Length==nameTwo.Length)
        {
            for(int i=0;i<stringLength;i++)
            {
                for(int j=0;j<stringLength;j++)
                {
                    if(nameOne[i]==nameTwo[j])
                    {
                        count+=1;
                        break;
                    }
                }
            }
            if(count==stringLength)
            {
                System.Console.WriteLine("Name one and two are Anagrams");
            }

        }
        else
        {
            System.Console.WriteLine("Name one and two are not a Anagrams");
        }
    }
}

