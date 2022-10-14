using System;
namespace Question6;
class Prgram{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the radius of the circle: ");
        double radius=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Formula key\n1. Area\n2. Perimeter\n3. Diameter");
        int formula=int.Parse(Console.ReadLine());
        double area=3.14*(radius*radius);
        double perimeter=2*3.14*radius;
        double diameter=2*radius;
        switch(formula)
        {
            case 1:
            {
                System.Console.WriteLine($"The area is: {area}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The area is:{perimeter}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The area is: {diameter}");
                break;
            }
            default:
            {
                System.Console.WriteLine("Wrong Input");
                break;
            }
        }
    }
}
