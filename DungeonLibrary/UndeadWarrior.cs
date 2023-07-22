using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class UndeadWarrior : Player
    {
        public UndeadWarrior()
        {
            Name = "Grimwald Shadowfang";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Undead";
            PlayerClass = "Warrior";
            IsEnhanced = false;
            Description = "Once a valiant knight defending Lordaeron, Grimwald ShadowFang fell victim to the Scourge's dark plague \nand rose again as an undead warrior. Tormented by his own undeath, Grimwald struggles to retain his fading memories \nof honor and loyalty while using his martial prowess to protect the forsaken remnants of his former kingdom and atone \nfor his unwitting role in the Scourge's devastation.";
        }


    }
}
