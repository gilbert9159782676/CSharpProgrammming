using System;
namespace StudentDetails;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your name: ");
        string name=Console.ReadLine();
        System.Console.Write("Enter age: ");
        int age=int.Parse(Console.ReadLine());
        System.Console.Write("Enter mark of subject 1: ");
        int subject1=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter mark of subject 2: ");
        int subject2=int.Parse(Console.ReadLine());
        System.Console.Write("Enter mark of subject 3: ");
        int subject3=int.Parse(Console.ReadLine());
        System.Console.Write("Enter Grade: ");
        char grade=char.Parse(Console.ReadLine());
        System.Console.Write("Enter mobile number: ");
        long mobileNumber=long.Parse(Console.ReadLine());
        System.Console.Write("Enter Mail id: ");
        string mailId=Console.ReadLine();
        System.Console.Write("Enter CGPA: ");
        float cgpa=float.Parse(Console.ReadLine());

        System.Console.WriteLine("Name: "+name);
        System.Console.WriteLine("Age: "+ age);
        System.Console.WriteLine("Mobile: "+ mobileNumber);
        System.Console.WriteLine("Marks1: "+subject1);
        System.Console.WriteLine("Marks2: "+subject2);
        System.Console.WriteLine("Marks3: "+subject3);
        float total=subject1+subject2+subject3;
        float average=total/3;
        System.Console.WriteLine("Total: "+total);
        System.Console.WriteLine("Average: "+Math.Round(average,2));
        System.Console.WriteLine("Grade: "+ grade);
        System.Console.WriteLine("Mail id: "+mailId);
        System.Console.WriteLine("CGPA: "+ Math.Round(cgpa,1));  
    }
}
