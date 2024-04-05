using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        //Question 1

        int i =0;
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        
        //Question 2
       
        int number ;
        Console.WriteLine("Enter a number");
        bool isNumber = int.TryParse(Console.ReadLine(),out number);
        while(!isNumber)
        {
            Console.WriteLine("Invalid input format.Please enter the input in number format");
            isNumber = int.TryParse(Console.ReadLine(),out number);
        }
         Console.WriteLine(number);
        
    }
}