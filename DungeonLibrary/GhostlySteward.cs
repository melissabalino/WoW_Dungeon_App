using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class GhostlySteward : Monster
    {
        public bool _isSleeping;
        public bool IsSleeping { get; set; }
        public int SleepingChance { get; set; }

        public GhostlySteward(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description, int sleepingChance) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description)
        {
            SleepingChance = sleepingChance;
            IsSleeping = new Random().Next(101) < sleepingChance;
        }
        public GhostlySteward()
        {
            Name = "Ghost";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "An ethereal servant bound to a haunted estate, forever carrying out its spectral duties.";
            IsSleeping = true;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
