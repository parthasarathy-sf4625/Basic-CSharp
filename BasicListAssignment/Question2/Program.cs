using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace Question2;

class Program 
{
    public static void Main(string[] args)
    {
        List<EmployeeDetails> employeeDetailsList = new List<EmployeeDetails>();

        int option = 0;

        do
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Select the Option : \n       1)Registration\n       2)Login\n       3)Exit ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            option = int.Parse(Console.ReadLine());


            if(option==1)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Enter your name : ");

                string name = Console.ReadLine();

                Console.Write("Enter your gender : ");

                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

                Console.Write("Enter your role : ");

                string role = Console.ReadLine();

                Console.Write("Enter your Team name: ");

                string teamName = Console.ReadLine();

                Console.Write("Enter your work location : ");

                WorkLocation workLocation = Enum.Parse<WorkLocation>(Console.ReadLine(),true);

    


                Console.Write("Enter your Date of Joining : ");

                DateTime doj = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                


                EmployeeDetails Employee = new EmployeeDetails(name,role,workLocation,teamName,gender,doj);

                employeeDetailsList.Add(Employee);


                int CurrentIndex =employeeDetailsList.Count-1;

                
                
                Console.WriteLine("Welcome your custumer ID is Generated : "+employeeDetailsList[CurrentIndex].EmployeeID);
                Console.WriteLine("---------------------------------------------------------");
            }

            else if(option==2)
            {
                Console.Write("Enter your Employee ID  :");
                string id = Console.ReadLine();

                int index =-1;

                for(int i = 0;i<employeeDetailsList.Count;i++)
                {
                    if(employeeDetailsList[i].EmployeeID == id)
                    {
                        index = i ;
                        break;
                    }
                }
                if(index < 0)
                {
                    Console.WriteLine("Invalid user name");
                    break;
                }
                int loginOption = 0;
            
                           
                Console.WriteLine("Select the Option : \n       1)Salary Calculation\n       2)Display Details\n       3)Exit");
                loginOption=int.Parse(Console.ReadLine());

                if(loginOption == 1)
                {

                    employeeDetailsList[index].SalaryCalculation();
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Your Current Balance is {employeeDetailsList[index].Salary}");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("---------------------------------------------------------");
                    
                }
                else if(loginOption == 2)
                {
                    employeeDetailsList[index].Display();
                }
                
            }

        }while(option!=3);
    }
}