using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class GnomeHunter : Player
    {
        public GnomeHunter()
        {
            Name = "Fizzle Quickspark";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Gnome";
            PlayerClass = "Hunter";
            IsEnhanced = false;
            Description = " a resourceful tinkerer and wildlife enthusiast, Fizzle Quickspark developed a deep bond with mechanical creatures after being rescued by a group of friendly robots during a dangerous expedition. Combining her engineering skills with her passion for the natural world, Fizzle embarks on daring adventures across Azeroth, accompanied by her loyal mechanical companions, seeking to protect both nature and her metal allies from any harm that may befall them.";
        }


    }
}
