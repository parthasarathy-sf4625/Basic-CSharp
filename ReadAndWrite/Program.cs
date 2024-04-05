using System;
namespace ReadAndWrite;
class Program {
    public static void Main(string[] args)
    {
        //Getting Inputs
        Console.Write("Enter your name : ");
        string name=Console.ReadLine();
        Console.Write("Enter your Father Name : ");
        string fatherName = Console.ReadLine();
        //Printing the Results
        //Concatenation
        Console.WriteLine(name+" "+fatherName);
        //PlaceHolder
        Console.WriteLine("{0} {1}",name,fatherName);
        //Interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}
