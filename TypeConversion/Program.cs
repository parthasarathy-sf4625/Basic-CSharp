using System;
using System.IO.Compression;
namespace TypeConverison;
class Program 
{
    public static void Main(string[] args)
    {
        int num1=Convert.ToInt32(null);
        Console.WriteLine(num1);

        Console.Write("Enter a Number : ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a Double Number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine(number1+number2);
        double number3 = double.Parse(Console.ReadLine());
        Console.WriteLine(number3);
    }
}