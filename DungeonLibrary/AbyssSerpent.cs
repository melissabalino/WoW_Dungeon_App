using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WoW_DungeonLibrary;

namespace WoW_Descriptions_Library
{
    public class AbyssSerpent : Monster
    {


        public AbyssSerpent(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }

        public AbyssSerpent()
        {
            Name = "Abyss Serpent";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A serpentine behemoth dwelling in the darkest depths of the ocean, luring ships to their doom.";

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
