using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string[] array = new string[5] {"Parthasarathy","Kholi","Dhoni","Rohit","Dhoni"};

    //Printing the Array
    
        for (int i=0 ; i<5 ; i++)
        {
            Console.WriteLine($" {array[i]} ");
        }

    
    
    //Getting the Search name

        Console.Write("Enter a name to search : ");
        string search = Console.ReadLine();

        int flag = 0;
        int[] index = new int[5];
        int count=0;
    
    //Using for

        for(int i = 0;i<5;i++)
        {
            if(array[i].ToLower()==search.ToLower())
            {
                flag = 1;
                index[count++] = i;
            }
        }


        if(flag == 1)
        {
            Console.Write($"The name is present in array \nThe index is ");
            for(int i=0;i<count;i++)
            {   if(i==count-1)
                {
                    Console.Write($"and {index[i]}");
                    break;
                }
                Console.Write($"{index[i]} ");
            }
        }
        else
        {
            Console.WriteLine("The name is not present in array");
        }
    
    
    //Using foreach
        flag=0;
    
        foreach (string name in array)
        {
            if(name.ToLower()==search.ToLower())
            {
                flag = 1;
                break;
            }
        }
        if(flag == 1)
        {
            Console.WriteLine($"\nThe name is present in array");
        }
        else
        {
            Console.WriteLine("The name is not present in array");
        }

    }
}