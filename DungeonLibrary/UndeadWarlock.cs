using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class UndeadWarlock : Player
    {
        public UndeadWarlock()
        {
            Name = "Mortimer Darkbane";
            HitChance = 75;
            Dodge = 25;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Undead";
            PlayerClass = "Warlock";
            IsEnhanced = true;
            Description = "Once a skilled mage in life, Mortimer Darkbane was tragically struck down during a cataclysmic event \nthat raised him as an Undead. Forsaking his former allies, he delved into the dark arts, seeking forbidden knowledge \nand power to avenge his demise and bring terror to those who wronged him in his new, undead existence.";
        }


    }
}
