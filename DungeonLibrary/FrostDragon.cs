using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class FrostDragon : Monster
    {


        public FrostDragon(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public FrostDragon()
        {
            Name = "Frost Dragon";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A majestic dragon, wielding the power of ice to freeze its foes in their tracks.";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
