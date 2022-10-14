using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        for(int counter=1;counter<=num;counter++)
        {
            System.Console.WriteLine($"Number is : {counter} and cube of the number is : {Math.Pow(counter,3)}");
        }
    }
}
