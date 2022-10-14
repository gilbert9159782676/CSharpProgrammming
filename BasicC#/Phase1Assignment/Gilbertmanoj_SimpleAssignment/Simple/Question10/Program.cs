using System;
namespace Qusestion10;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the character : ");
        char inputChar=char.Parse(Console.ReadLine().ToLower());
        if(inputChar=='a'||inputChar=='e'||inputChar=='i' ||inputChar=='o' ||inputChar=='u' )
        {
            System.Console.WriteLine("It is a vowel");
        }
        else
        {
            System.Console.WriteLine("It is not a vowel");
        }
    }
}
