using System;
namespace If;
class Program {
    public static void Main(string[] args)
    {
        Console.Write("Enter the mark: ");
        int marks = Convert.ToInt32(Console.ReadLine());
        //Grade A
        if (marks>80 && marks <=100)
        {
            Console.WriteLine("Grade A");
        }
        
        //Grade B
        else if(marks>60 && marks <=80)
        {
            Console.WriteLine("Grade B");
        }

        //Grade C
        else if(marks>=36 && marks <=60)
        {
            Console.WriteLine("Grade C");
        }

        //Grade D
        else if(marks<36 && marks>=0)
        {
            Console.WriteLine("Grade D");
        }

        //Invalid
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}