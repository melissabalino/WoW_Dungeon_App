using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class HumanHunter : Player
    {
        public HumanHunter()
        {
            Name = "Eleanor Oakheart";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Human";
            PlayerClass = "Hunter";
            IsEnhanced = false;
            Description = "An intrepid explorer and skilled archer, Eleanor Oakheart grew up in the outskirts of Elwynn Forest, forming a deep bond with the natural world and its creatures. Driven by her love for the wild and the thrill of the hunt, she embarks on daring expeditions to track down dangerous beasts and uncover hidden wonders across the realms of Azeroth.";
        }


    }
}
