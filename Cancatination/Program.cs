using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cancatination
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a few words !");
            string name = Console.ReadLine();
            char c = char.ToUpper(name[0]);
            name = name.Remove(0, 1);
            name = name.Insert(0, c.ToString());
            for (int i = 0; i < name.Length; i++)
                if (name[i] == ' ')
                {
                    c = char.ToUpper(name[i + 1]);
                    name = name.Remove(i + 1, 1);
                    name = name.Insert(i + 1, c.ToString());
                    Console.WriteLine("string is here" + name);




                }
        }
    }
}
