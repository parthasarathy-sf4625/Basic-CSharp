using System;
namespace ForLoop;
class Program 
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the lowerlimit : ");
       double lowerlimit = Convert.ToDouble(Console.ReadLine());

       Console.Write("Enter the upperlimit : ");
       double upperlimit = Convert.ToDouble(Console.ReadLine());

       double sum = 0;
       for(double i=lowerlimit+1;i<upperlimit;i++)
       {
        sum += i*i;
       }
       Console.WriteLine($"The sum of the Square of numbers between {lowerlimit} and {upperlimit} is {sum}");
    }
}