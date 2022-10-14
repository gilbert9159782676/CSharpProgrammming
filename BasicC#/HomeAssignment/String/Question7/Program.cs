using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Input the string : ");
        string input=Console.ReadLine().ToLower();
        int vowelCount=0;
        int consonantCount=0;
        for(int i=0;i<input.Length;i++)
        {
            if(input[i]=='a'||input[i]=='e' ||input[i]=='i'|| input[i]=='o' ||input[i]=='u')
            {
                vowelCount++;

            }
            else if(char.IsLetter(input[i]))
            {
                consonantCount++;
            }
        }
        System.Console.WriteLine($"The total number of vowel in the string is : {vowelCount}");
        System.Console.WriteLine($"The total number of consonant in the string is : {consonantCount}");
        
        
    }
}
