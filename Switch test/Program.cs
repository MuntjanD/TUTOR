using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("(unsatisfactory");
                    break;
                case 2:
                    Console.WriteLine("(unsatisfactory");
                    break;
                case 3:
                    Console.WriteLine("(unsatisfactory");
                    break;
                case 4:
                    Console.WriteLine("almost satisfactory");
                    break;
                case 5:
                    Console.WriteLine("satisfactory");
                    break;
                case 6:
                    Console.WriteLine("almost good");
                    break;
                case 7:
                    Console.WriteLine("good");
                    break;
                case 8:
                    Console.WriteLine("very good");
                    break;
                case 9:
                    Console.WriteLine("excelent");
                    break;
                case 10:
                    Console.WriteLine("with distinction");
                    break;
                default:
                    Console.WriteLine("exam not pased:");
                    break;
                    
            }








            }
        }
}
