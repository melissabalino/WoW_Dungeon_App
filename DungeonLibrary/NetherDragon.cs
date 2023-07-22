using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class NetherDragon : Monster
    {


        public NetherDragon(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public NetherDragon()
        {
            Name = "Nether Dragon";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "An otherworldly dragon, hailing from the Twisting Nether and wielding arcane energies beyond mortal comprehension.";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
