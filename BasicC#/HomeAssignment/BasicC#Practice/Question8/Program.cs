using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the meter value : ");
        int meter=int.Parse(Console.ReadLine());
        //a. CM = meter * 100 b. Mm – CM * 10 c. Inch – 39.3 * meter d. Foot – 12 * meter e. Mile - 0.0006213715277778 * meter
        double cm=meter * 100;
        double mm= meter * 1000;
        double inch= meter * 39.3;
        double foot= meter * 12;
        double mile =0.0006213715277778 * meter;

        System.Console.WriteLine($"CM = {cm} ");
        System.Console.WriteLine($"MM = {mm}");
        System.Console.WriteLine($"INCH = {inch}");
        System.Console.WriteLine($"FOOT = {foot}");
        System.Console.WriteLine($"MILE = {mile}");



    }
}
