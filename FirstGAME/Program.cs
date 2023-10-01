using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FirstGAME
{
    public class Character
    {
        public float Health;
        public int Armor;
        public int Damage;
        public int HP;
        //public Stats[] StatsArray; 
        
        
    }
    public class Stats
    {
        public int Agi;
        public int Str;
        public int Dex;
        
    }



    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("choise a Warrior" + "  1*  WARRIOR  : " + "  2*  MAGE: ");

            int choise = int.Parse(Console.ReadLine());

            Random rnd_dmg = new Random();
            Character Player = new Character();//create new player.
            Character Enemy = new Character();//create new enemy.
            Player.Health = 50;
            Enemy.Health = 50;
            Player.Armor = 50;
            Enemy.Armor = 50;
            Player.Damage = rnd_dmg.Next(1, 15);
            Enemy.Damage = rnd_dmg.Next(1, 15);

            Random stats = new Random();
            Stats PlayerStats = new Stats(); //Create NEW STats.
            Stats EnemyStats = new Stats();  // Creat new stats.

            Player.Armor += stats.Next(0, 1);


            PlayerStats.Agi = stats.Next(0, 2);
            {
                if (PlayerStats.Agi > 0)
                {
                    Player.Armor++;
                }
            }
            PlayerStats.Str = stats.Next(0, 2);
            {
                if (PlayerStats.Str > 0)
                {
                   Player.Damage ++;
                }
            }
            PlayerStats.Dex = stats.Next(0, 2);
            {
                if (PlayerStats.Dex > 0)
                {
                    Player.Armor += PlayerStats.Dex;
                }

                EnemyStats.Agi = stats.Next(0, 2);
                EnemyStats.Str = stats.Next(0, 2);
                EnemyStats.Dex = stats.Next(0, 2);

                //int EnemyMiss = miss.Next();            
                //int PlayerMiss = miss.Next();
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
                string ans = "y";
                do
                {
                    if (choise == 1)
                    {
                        Console.WriteLine("WARRIOR GET Random STATS:" + " STR :" + PlayerStats.Str + " AGI :" + PlayerStats.Agi + " DEX :" + PlayerStats.Dex);

                        Console.WriteLine("Warrior:" + "  HP :" + Player.Health + "  DMG :" + Player.Damage);
                        while (Player.Health > 0 && Enemy.Health > 0)
                        {
                            Console.WriteLine("WARRIOR HP: " + Player.Health + "  arm " + Player.Armor + "   :" + "  Warrior HIT : " + Player.Damage);
                            Console.WriteLine("MAGE    HP: " + Enemy.Health + "  arm " + Enemy.Armor + "    :" + "  MAGE HIT :    " + Enemy.Damage);
                            Console.WriteLine(" Attack  #1" + "     " + "Block   #2  ");
                            choise = int.Parse(Console.ReadLine());
                            if (choise == 1)
                            {
                                // Random random = new Random();
                                int damage = 100;
                                int armorDmg = Convert.ToInt32(damage * 0.37);
                                int healthDmg = damage - armorDmg;
                                Player.Health -= 0;
                                Player.Armor -= 0;




                                Player.Health -= Convert.ToSingle(rnd_dmg.Next(0, Enemy.Damage + 1)); // / 100 * Player.Armor;
                                Enemy.Health -= Convert.ToSingle(rnd_dmg.Next(0, Player.Damage + 1));// / 100 * Enemy.Armor;

                            }
                            if (choise == 2)
                            {
                                Player.Health -= (Enemy.Damage / 2);
                                Enemy.Health -= Player.Damage;
                                // Player.Health -= Convert.ToSingle(rnd_dmg.Next(0, Enemy.Damage + 1)) / 100 * Player.Armor;
                                // Enemy.Health -= Convert.ToSingle(rnd_dmg.Next(0, Player.Damage + 1)) / 100 * Enemy.Armor;

                            }




                        }
                        if (Player.Health <= 0 && Enemy.Health <= 0)
                        {
                            Console.WriteLine("DRAW");


                        }

                        else if (Player.Health <= 0)
                        {
                            Console.WriteLine("YOU :   LOST ");
                            Console.WriteLine("MAGE WIN. MAGE => HP :" + Enemy.Health);
                        }
                        else if (Enemy.Health <= 0)
                        {
                            Console.WriteLine("YOU :" + "WIN");

                            Console.WriteLine("Your Hero Stats, Get Random Ability! ");
                            PlayerStats.Dex = PlayerStats.Dex++;
                            PlayerStats.Agi = PlayerStats.Agi++;
                            PlayerStats.Str = PlayerStats.Str++;


                            Console.WriteLine("DEX :" + PlayerStats.Dex + "  AGI :" + PlayerStats.Agi + "  STR :" + PlayerStats.Str);
                            //PlayerStats.Dex = Player.Armor = 50*100/2;
                            //PlayerStats.Agi = Convert.ToInt32(Player.Health = 50 *100 / 35);
                            //PlayerStats.Str = Player.Damage * 100 / 2;
                            Console.WriteLine("Lvl UP : " + " Warrior get:" + "HP :" + Player.Health + "DMG :" + Player.Damage);
                            Console.Write(" Go To Next BOSS ? :" + "#1 - YES" + " #2 - NO");
                            choise = Convert.ToInt32(Console.ReadLine());
                            if (choise == 1)
                            {
                                if (Player.Health <= 0 || Enemy.Health <= 0)
                                {
                                    Player.Health = 100; Enemy.Health = 100;






                                }



                            }


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
                            Console.WriteLine("WARRIOR " + "HP :" + Player.Health);
                        }
                        else if (Player.Health <= 0)
                        {
                            Console.WriteLine("YOU WIN");
                            Console.WriteLine("MAGE HP :  " + Enemy.Health);
                        }
                    }
                    else
                        Console.WriteLine("See you again");
                    Console.WriteLine("Are you want to continue? ");
                    ans = Console.ReadLine();
                } while (ans != "n");
                Console.ReadKey();



            }
        }
    }
}
