using System;
namespace Question2;

class Program 
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        string[] strArr = str.Split(',');

        int[] arr = new int[N];

        int maxIndex = 0;
        int minIndex = 0;

        for(int i=0;i<N;i++)
        {
            arr[i] = int.Parse(strArr[i]);
            if(arr[i]>arr[maxIndex])
            {
                maxIndex =i;
            }
            if(arr[i]<arr[minIndex])
            {
                minIndex=i;
            }
        }
        int difference = Math.Abs(maxIndex-minIndex);
        Console.Write(difference);
    }
}
