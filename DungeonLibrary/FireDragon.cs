using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class FireDragon : Monster
    {


        public FireDragon(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public FireDragon()
        {
            Name = "Fire Dragon";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A mighty and fearsome dragon, wreathed in flames and capable of laying waste to entire landscapes.";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
