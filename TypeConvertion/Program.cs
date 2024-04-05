using System;
using System.Runtime.InteropServices;
namespace TypeCovertion;

class Program 
{
    public static void Main(string[] args)
    {
        //Name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        //Age
        Console.Write("Enter age: ");
        int age=Convert.ToInt32(Console.ReadLine());

        //Marks
        Console.Write("Enter the mark of subject1: ");
        double subject1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the mark of subject2: ");
        double subject2=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the mark on subject3: ");
        double subject3=Convert.ToDouble(Console.ReadLine());

        //Grade
        Console.Write("Enter Grade: ");
        char grade = Convert.ToChar(Console.ReadLine());

        //Mobilenumber
        Console.Write("Enter mobile number: ");
        double mobilenumber = Convert.ToDouble(Console.ReadLine());

        //Mail id
        Console.Write("Enter Mail id: ");
        string mailid = Console.ReadLine();
        
        double total = subject1+subject2+subject3;
        
        double average = (total /3); 

        Console.WriteLine($"Trainee Details Are: \nName: {name} \nAge: {age} \nMobile: {mobilenumber} \nMarks1: {subject1} \nMarks 2: {subject2} \nMarks3: {subject3}");
        Console.WriteLine($"Total: {total} \nAverage :{(average)} \nGrade: {grade} \nMail id:{mailid}");
    }
}