using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGAME
{
    public class Character
    {
        public int Health;
        public int Armor;
        public int Damage;
        public int HP;
    }

    internal class Program
    {
        static void Main(string[] args)

        {                       
            Console.Write("choise a Warrior" + "  1*  WARRIOR  : " + "  2*  MAGE: ");
            
            int choise = int.Parse(Console.ReadLine());
            //int attackblock = int.Parse(Console.ReadLine());
            Random miss = new Random();
            
            Random rnd_dmg = new Random();
            Character Player = new Character();//create new player.
            Character Enemy = new Character();//create new enemy.
            Player.Health = 200;
            Enemy.Health = 200;
            Player.Armor = 100;
            int EnemyMiss = miss.Next(11, 15);
                
            int PlayerMiss = miss.Next(11, 15);
            Enemy.Armor = 100;
            Player.Damage = rnd_dmg.Next(1, 15);
            Enemy.Damage = rnd_dmg.Next(1, 15);
            //int health = 100;
            //int health2 = 100;
            Console.WriteLine("*******FIGHT**********");
            //int damage = rnd_dmg.Next(1, 10);
            //int damage2 = rnd_dmg.Next(1, 10);
            //int armor2 = 50;
            //int armor = 50;
            //Player = (health + armor);
            //Enemy = (health2 + armor2);
            Console.WriteLine("YOUR CHOISE IS :" + choise);


            if (choise == 1)
            {

                while (Player.Health > 0 && Enemy.Health > 0)
                {
                    Console.WriteLine("WARRIOR HP: " + Player.Health + "   :" + "  Warrior HIT : "+ Enemy.Damage);
                    Console.WriteLine("MAGE    HP: " + Enemy.Health + "    :" + "  MAGE HIT :    "+ Player.Damage);

                    Player.Health -= Enemy.Damage;
                    Enemy.Health -= Player.Damage;





                }
                    if (Player.Health <= 0 && Enemy.Health <= 0)
                    {
                    Console.WriteLine("DRAW");
                    
                    
                    }

                    else if (Player.Health <= 0)
                    {
                    Console.WriteLine("YOU :" + "LOST");
                    Console.WriteLine("MAGE WIN. MAGE => HP :" + Enemy.Health   );
                    }
                    else if (Enemy.Health <= 0)
                    {
                    Console.WriteLine("YOU :" + "WIN");
                     }
                
            }
            
            if (choise == 2)
            {
                while (Player.Health > 0 && Enemy.Health > 0)
                {

                    Player.Health -= Convert.ToInt32(Enemy.Damage);
                    Enemy.Health -= Convert.ToInt32(Player.Damage);

                    Console.WriteLine("MAGE HP :" + Enemy.Health + "   Warrior HP :   " + Player.Health);
                    Console.WriteLine("MAGE hit: " + Player.Damage + "   " + " Warrior  HP  : " + (Player.Health - Enemy.Damage));


                }
                if (Player.Health <= 0 && Enemy.Health <= 0)
                {
                    
                    Console.WriteLine("DRAW");
                    Console.WriteLine("MAGE " + "HP :" + Enemy.Health);
                }

                else if (Enemy.Health <= 0)
                {
                    
                    Console.WriteLine("YOU LOST");
                    Console.WriteLine("WARRIOR " + "HP :" + Player.Health   );
                }
                else if (Player.Health <= 0)
                {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("MAGE HP :  "+  Enemy.Health);
                }
            }
            else
             Console.WriteLine("See you again"); 
            Console.ReadKey();



        }
    }
}
