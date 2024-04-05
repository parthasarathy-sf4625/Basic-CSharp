using System;
using System.Runtime.CompilerServices;
namespace Question1;
public enum Gender
{
    Male,
    Female,
    Transgener
}
public class CustumerDetails
{
    //Field
    
    private static long _custumerCount=1000;
    private string _custumerID="";

    //Auto Increment ID Properties
    public string CustumerId
    {
        get
        {
            return _custumerID;
        }
    }
    //Properties
    
    public string CustumerName{get;set;}
    public double Balance{get;set;}
    public Gender Gender{get;set;}
    public string Phone{get;set;}
    public string MailId{get;set;}
    public DateTime Dob{get;set;}


    public CustumerDetails(string name,Gender gender,string number,string mailid,DateTime dob)
    {

        _custumerID = "AB"+Convert.ToString(_custumerCount++);
        CustumerName = name;
        Gender = gender;
        Phone = number;
        MailId = mailid;
        Dob = dob;
    }
    public void Deposit()
    {
        Console.Write("Enter the amount to deposit : ");
        double Deposit = double.Parse(Console.ReadLine());
        Balance += Deposit;
    }

    public void Withdraw()
    {
        Console.Write("Enter the amount to withdraw: ");
        double Withdraw = double.Parse(Console.ReadLine());
        Balance-=Withdraw;
    }

   
}