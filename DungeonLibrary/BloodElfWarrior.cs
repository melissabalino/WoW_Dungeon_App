using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class BloodElfWarrior : Player
    {
        public BloodElfWarrior()
        {
            Name = "Lor'themar Sunshard";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Blood Elf";
            PlayerClass = "Warrior";
            IsEnhanced = false;
            Description = "Lor'themar Sunshard was once a promising spellcaster among the Blood Elves, but when the Sunwell's \ndestruction shattered his people's source of power, he turned to the path of a warrior. Rising to become a \nbattle-hardened leader, Lor'themar wields his ancestral blade with pride, driven by a burning determination to \nrestore Quel'Thalas to its former glory and safeguard his people from all threats.";
        }


    }
}
