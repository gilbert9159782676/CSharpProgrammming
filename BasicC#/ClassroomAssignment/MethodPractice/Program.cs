using System;
namespace MethodPractice;
class Program{
    public static void Main(string[] args)
    {
        string userNext="";
        do{
            System.Console.WriteLine("Enter the operation you want to perform :\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            int operation=int.Parse(Console.ReadLine());
            System.Console.Write("Enter the number1 : ");
            int num1=int.Parse(Console.ReadLine());
            System.Console.Write("Enter the number2 : ");
            int num2=int.Parse(Console.ReadLine());
                
            switch(operation)
            {
                case 1:
                {
                    Addition(num1,num2);
                    break;
                }
                case 2:
                {
                    Subtraction(num1,num2);
                    break;
                }
                case 3:
                {
                    Multiplication(num1,num2);
                    break;
                }
                case 4:
                {
                    Division(num1,num2);
                    break;
                }
            }
            System.Console.WriteLine("Do you want to continue?");
            userNext=Console.ReadLine();
        } while(userNext=="yes");

        void Addition(int num1,int num2)
        {
            System.Console.WriteLine($"The sum is : {num1+num2}");

        }
        void Subtraction(int num1,int num2)
        {
            System.Console.WriteLine($"The subtraction is : {num1-num2}");

        }
        void Multiplication(int num1,int num2)
        {
            System.Console.WriteLine($"The multiplication is : {num1*num2}");

        }
        void Division(int num1,int num2)
        {
            System.Console.WriteLine($"The division is : {num1/num2}");

        }
    }
}