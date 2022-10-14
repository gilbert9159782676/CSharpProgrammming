using System;
namespace Qyestion4;
class Program{
    public static void Main(string[] args)
    {
        int a;
        bool result;
        do
        {
            
            System.Console.Write("Enter the input: ");
            result=int.TryParse(Console.ReadLine(),out a );
            if(a>10 || a<0)
            {
                System.Console.Write("Wrong input.Enter the correct input: ");
                result=int.TryParse(Console.ReadLine(),out a );
            }
            else if (!result)
            {
                System.Console.Write("Wrong input.Enter the correct input: ");
                result=int.TryParse(Console.ReadLine(),out a );
            }
            
            

        }while(!result || a>10 ||a<0);

        System.Console.WriteLine($"Output: {a}");
    }

}
