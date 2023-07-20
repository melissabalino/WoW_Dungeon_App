using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class Direwolf : Monster
    {
        public bool _isSleeping;
        public bool IsSleeping { get; set; }
        public int SleepingChance { get; set; }

        public Direwolf(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description, int sleepingChance) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            SleepingChance = sleepingChance;
            IsSleeping = new Random().Next(101) < sleepingChance;
        }
        public Direwolf()
        {
            Name = "Wolf";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "Fierce and predatory beasts. They are known for their strength and aggression, so watch out when you're exploring, as they can pose a serious threat to unwary adventurers!";
            IsSleeping = true;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
