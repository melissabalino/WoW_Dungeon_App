using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class HumanWarrior : Player
    {
        public HumanWarrior()
        {
            Name = "Eleanor Oakheart";
            HitChance = 75;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Human";
            PlayerClass = "Warrior";
            IsEnhanced = false;
            Description = "Born into a noble family of seasoned knights, Eleanor Oakheart was groomed to uphold the honor and \ntraditions of her lineage. However, driven by a strong sense of justice and a desire to protect her homeland, \nshe defied her family's expectations, honing her skills as a warrior to fight for the innocent and maintain \npeace across Azeroth.";
        }


    }
}
