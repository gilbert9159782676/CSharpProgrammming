using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        string userNext="";
        do
        {
            System.Console.Write("Enter the number: ");
            int input=int.Parse(Console.ReadLine());
            if(input%2!=0)
            {
                System.Console.WriteLine("Given number is odd number");
            }
            else{
                System.Console.WriteLine("Given number is Even number");
            }
            System.Console.Write("Do you want to continue?: ");
            userNext=Console.ReadLine();
        }while(userNext=="yes");
    }
}
