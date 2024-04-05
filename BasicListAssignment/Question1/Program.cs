using System;
using System.Collections.Generic;
using System.Transactions;
namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        List<CustumerDetails> custumerList = new List<CustumerDetails>();

        int option=0;

        
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
                Console.Write("Enter your name : ");

                string name = Console.ReadLine();

                Console.Write("Enter your gender : ");

                Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

                Console.Write("Enter your mobile number : ");

                string number = Console.ReadLine();

                Console.Write("Enter your mail id : ");

                string mailid = Console.ReadLine();

                Console.Write("Enter your Date of Birth : ");

                DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                

                
                CustumerDetails custumer = new CustumerDetails(name,gender,number,mailid,dob);
                
                custumerList.Add(custumer);


                int CurrentIndex =custumerList.Count-1;

                
                
                Console.WriteLine("Welcome your custumer ID is Generated : "+custumerList[CurrentIndex].CustumerId);
                


            }
            else if(option==2)
            {

                
                Console.Write("Enter your ID  :");
                string id = Console.ReadLine();

                int index =-1;

                for(int i = 0;i<custumerList.Count;i++)
                {
                    if(custumerList[i].CustumerId == id)
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
            
                           
                Console.WriteLine("Select the Option : \n       1)Deposit\n       2)Withdraw\n       3)Balance Check\n       4)Exit");
                loginOption=int.Parse(Console.ReadLine());

                if(loginOption == 1)
                {
                    custumerList[index].Deposit();
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Your Current Balance is {custumerList[index].Balance}");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------");
                }
                else if(loginOption == 2)
                {
                    custumerList[index].Withdraw();
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Your Current Balance is {custumerList[index].Balance}");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------");
                    
                }
                else if(loginOption==3)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"Your Current Balance is {custumerList[index].Balance}");
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------");
                }

            }

            

        }while(option!=3);

        Console.WriteLine("Thanks for using");
        Console.WriteLine("Exitting.......!:)");
    }
}