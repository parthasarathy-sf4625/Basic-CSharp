
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Question2;
namespace Question3;

class Program 
{
    public static void Main(string[] args)
    {
        List<EbBill> EbList = new List<EbBill>();

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
                Console.Write("Enter your user name : ");

                string userName = Console.ReadLine();

                Console.Write("Enter your Phone Number: ");

                string phoneNumber = Console.ReadLine();

                Console.Write("Enter your Mail Id : ");

                string mailID = Console.ReadLine();            


                EbBill Eb = new EbBill(userName,phoneNumber,mailID);

                EbList.Add(Eb);


                int CurrentIndex =EbList.Count-1;

                
                
                Console.WriteLine("Welcome your custumer ID is Generated : "+EbList[CurrentIndex].MeterId);
                Console.WriteLine("---------------------------------------------------------");
            }

            else if(option==2)
            {
                Console.Write("Enter your user ID  :");
                string id = Console.ReadLine();

                int index =-1;

                for(int i = 0;i<EbList.Count;i++)
                {
                    if(EbList[i].MeterId == id)
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
            
                           
                Console.WriteLine("Select the Option : \n       1)Calculate Amount\n       2)Display Details\n       3)Exit");
                loginOption=int.Parse(Console.ReadLine());

                if(loginOption == 1)
                {

                    EbList[index].CalculateAmount();
                    EbList[index].DisplayBill();
                    
                }
                else if(loginOption == 2)
                {
                    EbList[index].Display();
                }
                
            }

        }while(option!=3);
    }
}