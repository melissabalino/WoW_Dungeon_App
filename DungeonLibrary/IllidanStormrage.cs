using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class IllidanStormrage : Monster
    {


        public IllidanStormrage(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public IllidanStormrage()
        {
            Name = "Illidan Stormrage";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A powerful and complex night elf, whose mastery of arcane and demonic powers make him both a fearsome ally and a dangerous adversary";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
