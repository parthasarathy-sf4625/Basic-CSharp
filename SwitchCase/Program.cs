using System;
namespace Switch;
class Program 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter value 1 : ");
        double value1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value 2 : ");
        double value2=Convert.ToDouble(Console.ReadLine());

        Console.Write(" 1)Addition(+)\n 2)Subraction(-)\n 3)Multiplication(*)\n 4)Division(/)\n 5)Modulo(%) \nEnter any one of the Opearation listed above:");
        char operation=Convert.ToChar(Console.ReadLine());

        double result=0;
        switch(operation)
        {
            case '+':
            {
                result = value1+value2;
                break;
            }
            case '-':
            {
                result = value1-value2;
                break;
            }
            case '*':
            {
                result = value1*value2;
                break;
            }
            case '/':
            {
                result = value1/value2;
                break;
            }
            case '%':
            {
                result = value1 % value2;
                break;
            }
            default:
            {
                Console.WriteLine("Operatioon is Invalid");
                break;
            }
        }
        Console.WriteLine($"The Result is {result}");
    }
}