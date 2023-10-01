using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistTEST2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cucumbers = {24, 25, 38, 100, int.MaxValue, int.MinValue };
           

            for (int i = 0; i < cucumbers.Length; i++)
            {
                
                Console.Write(cucumbers[i] + " ");
            }




        }
    }
}
