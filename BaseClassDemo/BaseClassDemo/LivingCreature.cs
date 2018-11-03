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

        public LivingCreature(string name, bool isAlive, int currentHP)
        {
            Name = name;
            IsAlive = isAlive;
            CurrentHP = currentHP;
        }

        public LivingCreature() { }
    }


}
