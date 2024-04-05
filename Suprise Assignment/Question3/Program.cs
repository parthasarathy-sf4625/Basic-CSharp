using System;
namespace Question3;

class Program 
{
    public static void Main(string[] args)
    {
        string str = "{()}}";//Console.ReadLine();

        bool balance = isBalanced(str);

        if(balance)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }

    static bool isBalanced(string str)
    {
        bool balance = true;
        if(str.Length%2 !=0 )
        {
            return false;
        }
        int rPointer = str.Length/2;
        int lPointer = (str.Length/2)-1;
        
        while(rPointer<str.Length)
        {
            if(countChar(str,str[lPointer])>1||countChar(str,str[rPointer])>0)
            {
                balance = false ;
                break;
            }

            if(!((str[lPointer]=='{') && (str[rPointer]=='}')||(str[lPointer]=='[') && (str[rPointer]==']')||(str[lPointer]=='(') && (str[rPointer]==')')))
            {
                balance= false;
                break;
            }     
            rPointer++;
            lPointer--;   
        }
        return balance;
    }

    static int countChar(string str,char ch)
    {
        int count=0;
        for(int i =0;i<str.Length;i++)
        {
            if(str[i]==ch)
            {
                count++;
            }
        }
        return count;
    }
}

