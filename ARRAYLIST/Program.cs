using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number of string");
            int n  = int.Parse(Console.ReadLine());
            string[] arraystring = new string[n];
            for(int i = 0; i < arraystring.Length; i++)
            {
                Console.Write("enter {0} string:",i + 1);
                arraystring[i] = Console.ReadLine();
            }
            Console.WriteLine(" your string are");
            for (int i = 0;i < arraystring.Length; i++)
                Console.WriteLine(arraystring[i]);
            for (int i = 0;  i < arraystring.Length; i++)
                for (int j = arraystring[i].Length - 1; j > i; i--)
                    if (arraystring[j].CompareTo(arraystring[j-1])<0)
                    {
                        string temp = arraystring[j];
                        arraystring[j] = arraystring[j-1];
                        arraystring[j-1] = temp;
                    }
                        Console.WriteLine("your sorted array are:");
                            for(int i =0;i <n;i++)
                                Console.WriteLine(arraystring[i]);



        }
    }
}
