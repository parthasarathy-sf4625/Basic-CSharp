using System;
using System.Threading;
namespace StringManipulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string searchString = Console.ReadLine();

            string[] array = inputString.Split(searchString);
            int count=array.Length;
            Console.WriteLine(count-1);
            
        }
    }
}