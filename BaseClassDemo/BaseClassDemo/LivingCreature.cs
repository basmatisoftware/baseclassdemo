using System;
using System.Collections.Generic;
using System.Text;

namespace BaseClassDemo
{
    public class LivingCreature
    {
        public string Name;
        public bool IsAlive;
        public int CurrentHP;
        public int Dexterity;

        public LivingCreature(string name, bool isAlive, int currentHP, int dexterity)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
            Dexterity = dexterity;
        }

        public LivingCreature() { }
    }


}
