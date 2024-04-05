using System;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
namespace Question2;
public enum WorkLocation
{
    home,
    office
}

public enum Gender
{
    Male,
    Female
}

public class EmployeeDetails
{
    //field
    //Auto increment ID
    private static long _employeeCount=0;

    private string _employeeID="";

    //properties

    public string EmployeeID{
        get{
                return _employeeID;
        }
    }

    public string EmployeeName{get;set;}

    public string Role{get;set;}

    public WorkLocation WorkLocation{get;set;}

    public string TeamName{get;set;}

    public DateTime Doj{get;set;}

    public int NoOfWorkingDays{get;set;}

    public int NoOfLeaves{get;set;}

    public Gender Gender{get;set;}

    public double Salary{get;set;}


    //Constructor

    public EmployeeDetails(string employeename,string role,WorkLocation workLocation,string teamName,Gender gender,DateTime doj)
    {
        _employeeID="SF"+Convert.ToString(_employeeCount++);

        

        EmployeeName = employeename;
        Role = role;
        WorkLocation = workLocation;
        TeamName = teamName;
        Gender = gender;
        Doj=doj;
    }


    //Methods

    public void SalaryCalculation()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.Write("Enter the No of Working days in the month: ");

        NoOfWorkingDays =int.Parse(Console.ReadLine());

        Console.Write("Enter the leaves you have taken in the  current month : ");

        NoOfLeaves = int.Parse(Console.ReadLine());
        Salary=(NoOfWorkingDays*500) - (NoOfLeaves*500);
        Console.WriteLine("---------------------------------------------------------");
    }

    public void Display()
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"Employee Name - {EmployeeName}");
        Console.WriteLine();
        Console.WriteLine($"Employee ID - {EmployeeID}");
        Console.WriteLine();
        Console.WriteLine($"Gender - {Gender}");
        Console.WriteLine();
        Console.WriteLine($"Role - {Role}");
        Console.WriteLine();
        Console.WriteLine($"Current Work Location - {WorkLocation}");
        Console.WriteLine();
        Console.WriteLine($"Team Name = {TeamName}");
        Console.WriteLine();
        if(Salary>0)
        {
            Console.WriteLine($"Salary for the Current Month - {Salary}");
        }
        else
        {
            Console.WriteLine("Salary for the Current Month - Please select Calculate Salary option in the previous menu to calculate the Salary");
        }
        Console.WriteLine();
        Console.WriteLine($"Date of Joining - {Doj.ToLongDateString()}");
        
        

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("---------------------------------------------------------");
    }
}