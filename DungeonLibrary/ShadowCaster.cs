using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class ShadowCaster : Monster
    {


        public ShadowCaster(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public ShadowCaster()
        {
            Name = "Shadowcaster";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "An elusive spellcaster adept at manipulating shadows and weaving dark magic.";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
