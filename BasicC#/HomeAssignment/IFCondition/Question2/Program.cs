using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your Age: ");
        int age = int.Parse(Console.ReadLine());
        if (age>=18)
        {
            System.Console.WriteLine("Congratulation!\nYou are eligible for casting your vote.");
        }
        else{
            System.Console.WriteLine("You are not eligible to vote.");
        }
    }

}
