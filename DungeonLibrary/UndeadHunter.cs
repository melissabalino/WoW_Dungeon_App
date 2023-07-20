using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class UndeadHunter : Player
    {
        public UndeadHunter()
        {
            Name = "Grimwald Shadowfang";
            HitChance = 70;
            Dodge = 50;
            MaxLife = 100;
            Life = 100;
            Faction = "Horde";
            Race = "Undead";
            PlayerClass = "Hunter";
            IsEnhanced = false;
            Description = "A renowned hunter in life, Grimwald Shadowfang met his end during an ill-fated encounter with a powerful creature in the depths of a haunted forest. Resurrected as an Undead, he now wields his mastery of the hunt to track down and capture elusive spectral beasts, seeking redemption for his past failures and a chance to free the spirits trapped in the realm of the living.";
        }


    }
}
