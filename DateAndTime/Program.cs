using System;
using System.Linq;
using System.Net.Mail;
namespace DateAndTime;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime date = new DateTime(2021,8,10,10,40,32);
       
       //Displaying Individually 
        Console.WriteLine(date.Year);
        Console.WriteLine(date.Month);
        Console.WriteLine(date.Day);
        Console.WriteLine(date.Hour);
        Console.WriteLine(date.Minute);
        Console.WriteLine(date.Second);

        //String Convertion
        string datetime = date.ToString("yyyy/MM/dd/ hh:mm:ss:tt");
        string[] dt = datetime.Split('/' ,':');
        int dateLen = dt.Length;

        //Reverse
        for(int i =dateLen-1;i>=0;i--)
        {
            Console.Write($"{dt[i]} ");
        }

        DateTime newdate = new DateTime();
        bool isValid=false;
        Console.WriteLine("\nEnter date and time in yyyy/mm/dd hh:mm:ss tt");
        isValid=DateTime.TryParseExact(Console.ReadLine(),"yyyy/mm/dd hh:mm:ss",null,System.Globalization.DateTimeStyles.None,out newdate);
        while(!isValid)
        {   
            Console.WriteLine("Enter a valid date");
            isValid=DateTime.TryParseExact(Console.ReadLine(),"yyyy/mm/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out newdate);
        }
        Console.WriteLine(newdate.Year);
        Console.WriteLine(newdate.Month);
        Console.WriteLine(newdate.Date);
    }
}