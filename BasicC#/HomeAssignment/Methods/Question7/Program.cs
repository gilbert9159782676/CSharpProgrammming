using System;
namespace Question7;
class program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the string : ");
        string input=Console.ReadLine();

        Palindrome(input);
        void Palindrome(string input)
        {
                string reverse="";
                for(int i=input.Length-1;i>=0;i--)
                {
                    reverse+=input[i];
                }
                if(input==reverse)
                {
                    System.Console.WriteLine("Palindrome");
                }
                else
                {
                    System.Console.WriteLine("Not a Palindrome");
                }


        }
    }
}
