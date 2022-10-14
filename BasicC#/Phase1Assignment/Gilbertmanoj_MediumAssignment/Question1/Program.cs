using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter your bascic salary: ");
        double basicSalary=double.Parse(Console.ReadLine());

        if(basicSalary<=10000)
        {
            double hra=(basicSalary*20)/100;
            double da=(basicSalary*80)/100;
            double annualGrossSalary=(basicSalary+hra+da)*12;
            double tax=(annualGrossSalary*6)/100;
            double insurance=(annualGrossSalary*1)/100;
            double takeHomeSalary=annualGrossSalary-tax-insurance;
            System.Console.WriteLine($"Annual Gross Salary is : {annualGrossSalary}");
            System.Console.WriteLine($"Take Home salary is : {takeHomeSalary}");
        }
        else if(basicSalary<=20000)
        {
            double hra=(basicSalary*25)/100;
            double da=(basicSalary*90)/100;
            double annualGrossSalary=(basicSalary+hra+da)*12;
            double tax=(annualGrossSalary*6)/100;
            double insurance=(annualGrossSalary*1)/100;
            double takeHomeSalary=annualGrossSalary-tax-insurance;
            System.Console.WriteLine($"Annual Gross Salary is : {annualGrossSalary}");
            System.Console.WriteLine($"Take Home salary is : {takeHomeSalary}");

        }
        else if(basicSalary>20000)
        {
            double hra=(basicSalary*30)/100;
            double da=(basicSalary*95)/100;
            double annualGrossSalary=(basicSalary+hra+da)*12;
            double tax=(annualGrossSalary*6)/100;
            double insurance=(annualGrossSalary*1)/100;
            double takeHomeSalary=annualGrossSalary-tax-insurance;
            System.Console.WriteLine($"Annual Gross Salary is : {annualGrossSalary}");
            System.Console.WriteLine($"Take Home salary is : {takeHomeSalary}");

        }
    }
}
