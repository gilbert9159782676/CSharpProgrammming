using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your physics Mark: ");
        int physics=int.Parse(Console.ReadLine());
        System.Console.Write("Enter your chemisrty Mark: ");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.Write("Enter Maths mark: ");
        int maths=int.Parse(Console.ReadLine());
        
        int sum=physics+chemistry+maths;
        double percentage=(sum*100)/300;
        System.Console.WriteLine("Sum = " + sum);
        System.Console.WriteLine("Percentage = "+ percentage);
         
    }
}
