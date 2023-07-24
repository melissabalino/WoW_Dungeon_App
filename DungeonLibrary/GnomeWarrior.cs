using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class GnomeWarrior : Player
    {
        public GnomeWarrior()
        {
            Name = "Fizzle Quickspark";
            HitChance = 75;
            Dodge = 25;
            MaxLife = 100;
            Life = 100;
            Faction = "Alliance";
            Race = "Gnome";
            PlayerClass = "Warrior";
            IsEnhanced = false;
            Description = "Fizzle Quickspark grew up tinkering and inventing contraptions in the mechanical wonderland of Gnomeregan.\nAfter the tragic fall of their city to invading troggs, Fizzle lost family and friends, vowing to carry on their legacy\nby merging his engineering genius with the art of swordplay, seeking vengeance against the enemies that destroyed \nhis home.";
        }


    }
}
