using System;
namespace AraryPractice;
class Program{
    public static void Main(string[] args)
    {
        string[] nameList=new string[5];
        for(int i=0;i<5;i++)
        {
            System.Console.Write($"Enter the name :");
            nameList[i]=Console.ReadLine();
        }
        //printing all names using forloop
        for(int i=0;i<nameList.Length;i++)
        {
            System.Console.WriteLine(nameList[i]);
        }

        System.Console.Write("Enter the name to search: ");
        string nameSearch=Console.ReadLine();

        //Foreach loop
        int index=0;
        bool result=false;
        foreach(string name in nameList )
        {
            if(nameSearch==name)
            {
                System.Console.WriteLine("The name is present in array");
                System.Console.WriteLine($"The index value is : {index} ");
                result=true;
                break;
            }
            
            index++;
        }
        if(result==false)
        {
           
            System.Console.WriteLine("The name is not present in array");
        }

        




        //for loop
        bool resultForLoop=false;
        for(int i=0;i<nameList.Length;i++)
        {
            if(nameList[i]==nameSearch)
            {
                System.Console.WriteLine("The name is present in array");
                System.Console.WriteLine($"The index value is : {i} ");
                resultForLoop=true;
                break;

            }
        }
        if(resultForLoop==false)
        {
            System.Console.WriteLine("The name is not present in array");
        }

        
    }
}
