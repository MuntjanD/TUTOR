using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_and_Cycles
{
    internal class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello what's your name ?:");
            string name = (string)Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("str.Length : = " + name.Length);
            Console.ReadKey();




        }
    }
}
