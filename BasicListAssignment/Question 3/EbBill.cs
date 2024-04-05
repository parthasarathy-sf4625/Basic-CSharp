using System;
namespace Question2;
public class EbBill
{
    //field
    //Auto increment ID
    private static long _meter=1001;
    private static long _billid=101;

    private string _meterId="";

    //properties

    public string MeterId{
        get{
                return _meterId;
        }
    }

    public string UserName{get;set;}

    public string PhoneNumber{get;set;}

    public string MailId{get;set;}

    public int UsedUnits {get;set;}

    public int Bill{get;set;}


    //Constructor

    public EbBill(string userName,string phoneNumber,string mailID)
    {
        _meterId="EB"+Convert.ToString(_meter++);    
        UserName = userName;
        PhoneNumber = phoneNumber;
        MailId = mailID;
    }


    //Methods

    public void CalculateAmount()
    {

        Console.Write("Enter the Units used: ");
        UsedUnits=int.Parse(Console.ReadLine());
        Bill = UsedUnits*5;
    }

    public void DisplayBill()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"                   BILLID - {_billid++}                              ");
        Console.WriteLine("---------------------------------------------------------");
        
        Console.WriteLine();
        Console.WriteLine($"User Name    -     {UserName}");
        Console.WriteLine();
        Console.WriteLine($"Meter ID     -     {MeterId}");
        Console.WriteLine();
        Console.WriteLine($"Phone Number -     {PhoneNumber}");
        Console.WriteLine();
        Console.WriteLine($"Mail Id      -     {MailId}");
        Console.WriteLine();
        Console.WriteLine($"Amount       -     {Bill}");
        Console.WriteLine("---------------------------------------------------------");
    }

    public void Display()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
        
        Console.WriteLine($"User Name    -     {UserName}");
        Console.WriteLine();
        Console.WriteLine($"Meter ID     -     {MeterId}");
        Console.WriteLine();
        Console.WriteLine($"Phone Number -     {PhoneNumber}");
        Console.WriteLine();
        Console.WriteLine($"Mail Id      -     {MailId}");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------");
    }
}