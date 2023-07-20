using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class GnomeWarlock : Player
    {
        public GnomeWarlock()
        {
            Name = "Widget Cogsworth";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Gnome";
            PlayerClass = "Warlock";
            IsEnhanced = true;
            Description = "A curious and eccentric gnome, Widget Cogsworth delved into the arcane arts to gain knowledge and understanding of the mysterious forces that shape Azeroth. In a quest for power and scientific advancement, Widget formed a pact with a shadowy entity, embracing the dark side of magic, and now seeks to balance the fine line between mastery and control while unraveling the secrets of forbidden knowledge.";
        }


    }
}
