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
            int[] sectors = { 6, 28, 15, 15, 17 };
            bool isOpen = true;

            while (isOpen)


            {
                Console.SetCursorPosition(0, 20);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($" Sector # {i + 1} free {sectors[i]} seats.");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Registration : ");
                Console.WriteLine("\n\n1 - Register seat.\n \n2 - exit from APP.\n\n");
                Console.WriteLine(" Choise #1 or #2");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write("Wich Sector you want ?");
                        userSector = Convert.ToInt32(Console.ReadLine()) -1 ;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("ERRROR IN SECTOR ");
                            break;
                        }
                        Console.WriteLine("how many seats you need ?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (sectors[userSector] < userPlaceAmount ||  userPlaceAmount < 0)
                        {
                            Console.WriteLine($"ERROR IN PLACE {userSector} NOT ENOUGHT SEATS! + " +
                                $" In Sector left : {sectors[userSector] }");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        break;
                    case 2:
                        isOpen = false;
                        break; 
                    
                        


                }



                Console.ReadKey();
                Console.Clear();
            }

            


        }
    }
}
