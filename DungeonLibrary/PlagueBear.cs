using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WoW_Descriptions_Library;

namespace WoW_DungeonLibrary
{
    public class PlagueBear : Monster
    {
        public PlagueBear(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) { }
        public PlagueBear()
        {
            Name = "Bear";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A corrupted and diseased bear, spreading pestilence wherever it roams.";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
