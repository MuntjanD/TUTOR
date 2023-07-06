using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileForDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = (Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (char.IsDigit(str[i]))
                    count++;
            Console.WriteLine("String \"{0}\" has {1} digit(s)", str,count);















            Console.ReadKey();
        }
    }
}
