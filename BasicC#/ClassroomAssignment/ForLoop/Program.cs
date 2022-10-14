using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    { // printing even numbers
        for(int num=0;num<=25;num++)
        {
            if(num%2==0){
                System.Console.Write($"{num} ");
            }
        }

        // Square sequence from user input
        System.Console.Write("\nEnter the initial Value: ");
        int initial_val=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the Final Value: ");
        int final_val=int.Parse(Console.ReadLine());

        int result=0;
        for(int counter=initial_val;counter<=final_val;counter++)
        {
            result=result+(counter*counter);
        }
        System.Console.WriteLine("The output is: " + result);

    }
}