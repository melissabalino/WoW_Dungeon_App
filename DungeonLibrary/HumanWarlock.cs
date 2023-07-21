using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class HumanWarlock : Player
    {
        public HumanWarlock()
        {
            Name = "Victoria NightShade";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Human";
            PlayerClass = "Warlock";
            IsEnhanced = true;
            Description = "A once-prominent noblewoman in Stormwind, Victoria NightShade delved into forbidden arcane arts after a tragic encounter with a sinister cult. Forsaking her privileged life, she embraced the path of a Warlock, seeking dark power to avenge her family's downfall and confront the very forces that led her astray.";
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

}
