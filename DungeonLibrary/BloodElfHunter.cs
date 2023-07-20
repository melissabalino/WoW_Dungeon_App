using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class BloodElfHunter : Player
    {
        public BloodElfHunter()
        {
            Name = "Lor'themar Sunshard";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Blood Elf";
            PlayerClass = "Hunter";
            IsEnhanced = false;
            Description = "A skilled archer and Blood Knight in the service of Silvermoon, Lor'themar Sunshard developed a profound connection with the natural world during his solitary hunts in the forests of Quel'Thalas. Embracing the path of a Hunter, he now seeks to protect his homeland and honor his people's traditions, combining both his mastery of the bow and his affinity for the wild to defend Silvermoon from any looming threats.";
        }


    }
}
