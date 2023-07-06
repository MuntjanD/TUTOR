using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Credit Calculator !" );
            Console.WriteLine("Type Sum !"  );
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Type how many years? "  );
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("What's % ?  ");
            float p = float.Parse(Console.ReadLine());
           

            
            p = p / 100; 
            double m = (n * p * Math.Pow((1 + p), y)) / (12 * (Math.Pow((1 + p), y) - 1));
            float s = (float)(m * 12) * y;
            Console.WriteLine("Sum per month: of Eur: " + Math.Round(m),2);
            Console.WriteLine("Total Sum:  of " + (s));





            //p = p / 100;
            //m = (n * p * pow((1 + p), y)) / (12 * (pow(1 + p, y) - 1));
            //s = m * 12 * y;
            //p = p / 100;
            //m = (n * p * pow((1 + p), y)) /(12 * (pow(1 + p, y) - 1));
            //printf("Ежемесячно: %.0f руб.\n", m);
            //printf("Общая сумма: %.0f руб.\n", s);
            //float m = (float)((float)(Sum * perc * Math.Pow((1 + perc), year)) / (12 * Math.Pow(1 + perc, year) - 1));












            Console.ReadKey();





        }
    }
}
