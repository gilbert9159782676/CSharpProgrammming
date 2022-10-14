using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string: ");
        string input=Console.ReadLine();
        string outputString="";
        
        for(int i=0;i<input.Length;i++)
        {
            if(char.IsNumber(input[i]))
            {
                outputString+=input[i];
            }
        }
        int outputNum=int.Parse(outputString);

        if(outputNum%2!=0)
        {
            System.Console.WriteLine($"{outputNum} is odd number.");
        }
        else{
            System.Console.WriteLine($"{outputNum} is Even number.");
        }
    }
}
