using System;
using System.Collections.Generic;
using System.Text;

namespace BaseClassDemo
{
    public static class GameEngine
    {
        static public int battleCount;

        //Hand2Hand Player versus Monster
        public static void H2HPlayerBattleMonster(Player player, Monster monster)
        {
            Console.WriteLine("\n\nH2H Player {0} v. Monster {1}", player.Name, monster.Name);
            
            //Dexterity determines who goes first...
            if (player.Dexterity >= monster.Dexterity)
            {
                //Player goes first
                int damage = RollDie(player.Strength);
                DamageMonster(monster, damage);
                if (monster.IsAlive)
                {
                    damage = RollDie(monster.Strength);
                    DamagePlayer(player, damage);
                } //TODO: Monster is dead... give up rewards...

                
            } else
            {
                //Monster goes first
                int damage = RollDie(monster.Strength);
                //TODO:  Check if monster died... if so, give up rewards
                DamagePlayer(player, damage);
                if (player.IsAlive)
                {
                    damage = RollDie(player.Strength);
                    DamageMonster(monster, damage);
                }
                
            }


            
        }

        private static void DamageMonster(Monster monster, int damage)
        {
            Console.WriteLine("***{0} is hit with {1} damage.", monster.Name, damage);
            monster.CurrentHP -= damage;
            if (monster.CurrentHP < 0)
            {
                monster.IsAlive = false;
                monster.CurrentHP = 0;
            }

        }

        private static void DamagePlayer(Player player, int damage)
        {
            Console.WriteLine("***{0} is hit with {1} damage.", player.Name, damage);
            player.CurrentHP -= damage;
            if (player.CurrentHP < 0)
            {
                player.IsAlive = false;
                player.CurrentHP = 0;
            }

        }


        public static int RollDie(int max)
        {
            Random rnd = new Random();
            return rnd.Next(max);
        }

    }//class GameEngine
}
