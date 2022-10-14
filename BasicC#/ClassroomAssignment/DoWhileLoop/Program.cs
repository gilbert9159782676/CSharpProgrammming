using System;
namespace DoWhileLoop;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the user input: ");
        int num=int.Parse(Console.ReadLine());
        string input=""; 
        do
        {
            if(num%2!=0)
            {
                System.Console.WriteLine("Odd");
            }
            else
            {
                System.Console.WriteLine("Even");

            }

            System.Console.Write("You want to check with any other number? ");
            input=Console.ReadLine();

            while(true){
                if(input=="yes" || input=="no")
                {
                    break;
                
                }
                else{
                    System.Console.WriteLine("Input is wrong.Enter the valid input !");
                    System.Console.Write("You want to check with any other number? ");
                    input=Console.ReadLine();
                }


            }
            System.Console.Write("Enter the user input: ");
            num=int.Parse(Console.ReadLine());    
        }while( input=="yes");
    }
}
