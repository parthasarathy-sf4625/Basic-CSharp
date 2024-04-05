using System;
namespace DoWhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        string toContinue = string.Empty;
        int number;

        do
        {
            Console.WriteLine("Enter a number");
            number=Convert.ToInt32(Console.ReadLine());

            //Odd or Even

            if(number%2==0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }

            Console.WriteLine("Do you want to repeat the process ? yes/no");
            
            
            toContinue=Console.ReadLine();
            
            //Checking to continue or Not
            
            while(true)
            {
                if(toContinue.ToLower()=="yes" ||toContinue.ToLower()=="no")
                {
                   break;
                }
        
                else
                {
                    Console.WriteLine("Invalid , Enter a valid Input");
                    toContinue=Console.ReadLine();
                }
            }
        }while(toContinue.ToLower()=="yes");
    }
        
}
