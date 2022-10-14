using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the customer Id: ");
        string cusId=Console.ReadLine();
        System.Console.Write("Enter the Name: ");
        string name=Console.ReadLine();
        System.Console.Write("Enter the unit consumed: ");
        int unit=int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Customer IDNO : {cusId}");
        System.Console.WriteLine($"Customer Name : {name}");
        System.Console.WriteLine($"unit Consumed : {unit}");
        
        if(unit<=199)
        {
            double amount= unit *1.20;
            double surcharge =100;
            System.Console.WriteLine($"Amount Charges @Rs.1.20 per unit: {amount}");
            System.Console.WriteLine($"Surcharge amount : {surcharge}");
            System.Console.WriteLine($"Net amount paid by the customer: {amount+surcharge}");

        }
        else if(unit>=200 && unit<400)
        {
            double amount= unit *1.50;
            double surcharge =100;
            System.Console.WriteLine($"Amount Charges @Rs.1.50 per unit: {amount}");
            System.Console.WriteLine($"Surcharge amount : {surcharge}");
            System.Console.WriteLine($"Net amount paid by the customer: {amount+surcharge}");

        }
        else if(unit>=400 && unit<600)
        {
            double amount= unit *1.80;
            double surcharge =(amount*0.15);
            System.Console.WriteLine($"Amount Charges @Rs.1.80 per unit: {amount}");
            System.Console.WriteLine($"Surcharge amount : {surcharge}");
            System.Console.WriteLine($"Net amount paid by the customer: {amount+surcharge}");

        }
        else if(unit>600)
        {
            double amount= unit *2.00;
            double surcharge =(amount*0.15);
            System.Console.WriteLine($"Amount Charges @Rs.2.00 per unit: {amount}");
            System.Console.WriteLine($"Surcharge amount : {surcharge}");
            System.Console.WriteLine($"Net amount paid by the customer: {amount+surcharge}");

        }
    }
    
}
