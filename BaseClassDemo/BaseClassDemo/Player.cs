using System;
using System.Collections.Generic;
using System.Text;

namespace BaseClassDemo
{
    public class Player:LivingCreature
    {
        bool HasArmor;
        int Level;
        int Gold;

        public Player(string name, bool isAlive, int currentHP, int dexterity,bool hasArmor, int level, int gold):base(name, isAlive, currentHP, dexterity)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            Dexterity = dexterity;
            HasArmor = hasArmor;
            Level = level;
            Gold = gold;
        }

        //Methods
        public void ReportStats()
        {
            Console.WriteLine("Player Name: {0}", Name);
            Console.WriteLine("\tIs Alive:{0}", IsAlive);
            Console.WriteLine("\tHP: {0} \tDEX:{1}", CurrentHP, Dexterity);
            Console.WriteLine("\tHas Armor:{0}", HasArmor);
            Console.WriteLine("\tLevel: {0}\t Gold:{1}", Level, Gold);
        }

    }


}
