﻿using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the temperature: ");
        int temp=int.Parse(Console.ReadLine());

        if (temp<=0)
        {
            System.Console.WriteLine("Freezing weather");
        }
        else if(temp>=0 && temp<10)
        {
            System.Console.WriteLine("Very cold weather");
        }
        else if(temp>=10 && temp<20)
        {
            System.Console.WriteLine("Cold weather");
        }
        else if(temp>=20 && temp<30)
        {
            System.Console.WriteLine("Normal in Temp");
        }
        else if(temp>=30 && temp<40)
        {
            System.Console.WriteLine("Its Hot");
        }
        else if(temp>=40)
        {
            System.Console.WriteLine("Its Very Hot");
        }
    }
}
