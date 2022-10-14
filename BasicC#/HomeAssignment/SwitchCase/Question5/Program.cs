using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the country:\nIndia\nPakistan\nBangladesh");
        string country=Console.ReadLine().ToUpper();
        switch(country){
            case "INDIA":
            {
                System.Console.WriteLine("Output:\n1. Gambir\n2. Ashwin\n3. Dhoni\n4. Jadeja");
                break;
            }
            case "PAKISTAN":
            {
                System.Console.WriteLine("Output:\n1. Shahid Afridi\n2. Javed Miandad\n3. Younis Khan\n4. Wasim Akram");
                break;
            }
            case "BANGLADESH":
            {
                System.Console.WriteLine("Output:\n1. Shakib AI Hasan\n2. Tamim Iqbal\n3. Litton Das\n4. Mehidy Hasan");
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
