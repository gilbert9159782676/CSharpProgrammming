using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the physics mark: ");
        int physics=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the chemistry mark: ");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.Write("Enter the maths mark: ");
        int maths=int.Parse(Console.ReadLine());

        int total=physics+chemistry+maths;
        double percentage=(total*100)/300;

        if (percentage>=75)
        {
            System.Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            System.Console.WriteLine("The candidate is Not eligible for admission.");
        }
        
    }
}
