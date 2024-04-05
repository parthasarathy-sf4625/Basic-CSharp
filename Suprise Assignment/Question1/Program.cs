using System;
using System.Runtime.CompilerServices;
namespace Question1;

class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
       
        string str = Console.ReadLine();
        string[] strArr = str.Split(',');

        int[] arr = new int[N];
       
        for(int i = 0 ;i<N;i++)
        {
            arr[i]=int.Parse(strArr[i]);
            if(i>0 && arr[i]<arr[i-1])
            {
                Console.Write($"{arr[i-1]} ");
            }
        }
        Console.Write(arr[N-1]);
    }
}