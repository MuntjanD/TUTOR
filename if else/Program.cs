using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter aprtament nr. :");
            int flat = int.Parse(Console.ReadLine());
            if (flat > 0 && flat < 21)
            {
                Console.WriteLine("this flat in building 1");
            }
            if (flat > 21 && flat < 49)
            {
                Console.WriteLine("this flat in building 2");
            }
            else if (flat > 48 && flat < 91)
            {
                Console.WriteLine("this flat in building 3");
            }
            else {}; 

            Console.ReadKey();
                



        }
    }
}
