using System;
using System.Collections.Generic;
using System.Text;

namespace BaseClassDemo
{
    public class Monster:LivingCreature
    {
        public int RewardGold;
        public int RewardXP;

        //add dexterity
        public Monster(string name, bool isAlive, int currentHP, int dexterity, int rewardGold, int rewardXP):base(name, isAlive, currentHP, dexterity)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            RewardGold = rewardGold;
            RewardXP = rewardXP;
            Dexterity = dexterity;
        }

    }

  

}
