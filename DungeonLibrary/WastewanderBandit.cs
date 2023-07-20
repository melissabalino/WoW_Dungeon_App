using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class WastewanderBandit : Monster
    {
        public bool _isShielded;
        public bool IsShielded { get; set; }
        public int ShieldedChance { get; set; }

        public WastewanderBandit(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description, int shieldedChance) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            ShieldedChance = shieldedChance;
            IsShielded = new Random().Next(101) < shieldedChance;
        }
        public WastewanderBandit()
        {
            Name = "Bandit";
            HitChance = 6;
            Dodge = 18;
            MaxLife = 30;
            Life = MaxLife;
            MaxDamage = 8;
            MinDamage = 2;
            Description = "Bandits are a sneaky and dangerous group of outlaws. Be careful around them, as they'll ambush you and steal your loot if you're not careful!";
            IsShielded = true;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
