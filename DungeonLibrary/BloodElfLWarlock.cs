using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class BloodElfWarlock : Player
    {
        public BloodElfWarlock()
        {
            Name = "Kael'thas Emberblade";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Blood Elf";
            PlayerClass = "Warlock";
            IsEnhanced = true;
            Description = "A gifted Blood Elf sorcerer, Kael'thas Emberblade turned to dark magic after witnessing the destruction \nof his homeland during the Scourge invasion. Consumed by vengeance and thirst for power, he made a pact with demonic \nforces, wielding fel energy to rebuild his shattered kingdom and secure the future of his people, even if it meant \nrisking his very soul.";
        }


    }
}
