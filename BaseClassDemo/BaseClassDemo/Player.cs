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



    }


}
