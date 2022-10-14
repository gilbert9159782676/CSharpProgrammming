using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the value of N: ");
        int input=int.Parse(Console.ReadLine());
        bool result;
        System.Console.WriteLine($"Leap years from 1 to {input}:");
        for(int year=1;year<=input;year++)
        {
                    
                    if(year%4==0)
                    {
                        if((year%100!=0) || (year%400==0))
                        {
                                result=true;
                        }
                        else
                        {
                                result=false;

                        }
                    }
                    else
                    {
                                result=false;
                    }
                    if(result==true){

                        System.Console.Write($"{year} ");}
        }            
    }
}

