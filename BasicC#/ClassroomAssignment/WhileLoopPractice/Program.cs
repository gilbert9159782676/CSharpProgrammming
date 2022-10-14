using System;
namespace WhileLoopPractice;
class Program{
    public static void Main(string[] args)
    {
        // print the even numbers upto 25
        int val=2;
        while(val<=25)
        {
            System.Console.Write($"{val} ");
            val+=2;
        }

        // exercise 2
        System.Console.Write("\nEnter the input: ");
        int input;
        bool result=int.TryParse(Console.ReadLine(),out input);
                                                
        while(result!=true)
        {                       
            System.Console.WriteLine("Invalid input format. Please enter the input in number format");
            result=int.TryParse(Console.ReadLine(),out input);

        }
        System.Console.WriteLine($"The number is : {input}");



    }
}
