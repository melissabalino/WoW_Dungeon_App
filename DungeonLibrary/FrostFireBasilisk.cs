using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class FrostFireBasilisk : Monster
    {
        

        public FrostFireBasilisk(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife, maxDamage, minDamage, description) {}
        
        public FrostFireBasilisk()
        {
            Name = "Basilisk";
            HitChance = 5;
            Dodge = 8;
            MaxLife = 20;
            Life = MaxLife;
            MaxDamage = 7;
            MinDamage = 1;
            Description = "A reptilian creature embodying both icy and fiery elements, known for its deadly breath.";
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
