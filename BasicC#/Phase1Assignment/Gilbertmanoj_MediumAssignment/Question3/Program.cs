using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Day : ");
        int day=int.Parse(Console.ReadLine());
        System.Console.Write("Month : ");
        int month=int.Parse(Console.ReadLine());
        System.Console.Write("Year : ");
        int year=int.Parse(Console.ReadLine());
        
        DateTime inputData=new DateTime(year,month,day);
        System.Console.WriteLine("The formatted Date is : ");
        System.Console.WriteLine(inputData.ToString("dd/MM/yyyy"));
        DateTime today=DateTime.Now;
        if(inputData.Day==today.Day && inputData.Month==today.Month && inputData.Year==today.Year )
        {
            System.Console.WriteLine("The current date status : True");
        }
        else
        {
            System.Console.WriteLine("The current date status : False");
        }
    }
}

