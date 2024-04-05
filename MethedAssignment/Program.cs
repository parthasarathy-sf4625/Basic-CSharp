using System;
using System.Security.Principal;
namespace MethodAssignment;
class Program
{
    public static void Main(string[] args)
    {
        

        string toCont = "";

        do
        {
            Console.Write("Enter number 1 : ");
            Console.Write("Enter number 2 : ");
            double number1 = double.Parse(Console.ReadLine());

            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an option\n1)Addition\n2)Subtraction\n3)Multiplication\n4)Division");

            int choise=int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                {
                    Console.WriteLine($"{Add(number1,number2)}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"{Sub(number1,number2)}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"{Mul(number1,number2)}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"{Div(number1,number2)}");
                    break;
                }
            }
            Console.WriteLine("Do you want to Continue? yes/no");
            toCont=Console.ReadLine();
        }while(toCont.ToLower()=="yes");

    }
    static double Add(double n1,double n2)
    {
        double sum = n1+n2;
        return sum;
    }
    static double Sub(double n1,double n2)
    {
        double sub = n1-n2;
        return sub;
    }
    static double Mul(double n1,double n2)
    {
        double mul = n1*n2;
        return mul;
    }
    static double Div(double n1,double n2)
    {
        double div = n1/n2;
        return div;
    }
    

}