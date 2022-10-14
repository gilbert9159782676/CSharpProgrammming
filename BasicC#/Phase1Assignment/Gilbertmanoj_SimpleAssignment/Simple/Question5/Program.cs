using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        double basicSalary=10000;
        double da=(basicSalary*10)/100;
        double hra=(basicSalary*10)/100;
        double total=basicSalary +hra+da;
        double annualTotal=12*total;
        double tax=(annualTotal*5)/100;
        double annualSalary=annualTotal-tax;
        System.Console.WriteLine($"The annual salary = {annualSalary}");

    }
}
