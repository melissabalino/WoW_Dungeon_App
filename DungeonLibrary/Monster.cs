using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using WoW_Descriptions_Library;

namespace WoW_DungeonLibrary
{
    public class Monster : Character
    {
        public int _minDamage;
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage;  }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }
        public string Description { get; set; }

        public Monster(string name, int hitChance, int dodge, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, dodge, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster() { }
        public override string ToString()
        {
            return base.ToString() +
                   $"Attack Strength: {MinDamage} to {MaxDamage} power\n\n" +
                   $"Description: {Description}\n\n" +
                   $"=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=";
        }
        public static Queue<Monster> GetMonsters()
        {
            Direwolf direwolf = new Direwolf("Direwolf", 50, 25, 25, 10, 7, "A fierce and formidable wolf, renowned for its strength and hunting prowess.", 50);
            WastewanderBandit wastewanderBandit = new WastewanderBandit("Wastewander Bandit", 15, 25, 25, 12, 7, "A cunning and elusive desert outlaw, preying on unsuspecting travelers in arid regions.", 50);
            GhostlySteward ghostlySteward = new GhostlySteward("Ghostly Steward", 50, 25, 25, 10, 7, "An ethereal servant bound to a haunted estate, forever carrying out its spectral duties.", 50);
            PlagueBear plagueBear = new PlagueBear("Plague Bear", 50, 25, 25, 10, 7, "A corrupted and diseased bear, spreading pestilence wherever it roams.");
            FrostFireBasilisk frostFireBasilisk = new FrostFireBasilisk("Frost Fire Basilisk", 50, 25, 25, 10, 7, "A reptilian creature embodying both icy and fiery elements, known for its deadly breath.");
            ShadowCaster shadowcaster = new ShadowCaster("Shadowcaster", 50, 25, 25, 10, 7, "An elusive spellcaster adept at manipulating shadows and weaving dark magic.");
            AbyssSerpent abyssSerpent = new AbyssSerpent("Abyss Serpent", 50, 25, 25, 10, 7, "A serpentine behemoth dwelling in the darkest depths of the ocean, luring ships to their doom.");
            FireDragon fireDragon = new FireDragon("Fire Dragon", 50, 25, 25, 10, 7, "A mighty and fearsome dragon, wreathed in flames and capable of laying waste to entire landscapes.");
            FrostDragon frostDragon = new FrostDragon("Frost Dragon", 50, 25, 25, 10, 7, "A majestic dragon, wielding the power of ice to freeze its foes in their tracks.");
            NetherDragon netherDragon = new NetherDragon("Nether Dragon", 50, 25, 25, 10, 7, "An otherworldly dragon, hailing from the Twisting Nether and wielding arcane energies beyond mortal comprehension.");
            Monster illidanStormrage = new Monster("Illidan Stormrage", 100, 50, 30, 15, 10, "A powerful and complex night elf, whose mastery of arcane and demonic powers make him both a fearsome ally and a dangerous adversary");

            Direwolf wolf = new Direwolf();
            WastewanderBandit bandit = new WastewanderBandit();
            GhostlySteward ghost = new GhostlySteward();
                       
            Queue<Monster> m = new Queue<Monster>();
            m.Enqueue(direwolf);
            m.Enqueue(wastewanderBandit);
            m.Enqueue(ghostlySteward);
            m.Enqueue(plagueBear);
            m.Enqueue(frostFireBasilisk);
            m.Enqueue(shadowcaster);
            m.Enqueue(abyssSerpent);
            m.Enqueue(fireDragon);
            m.Enqueue(frostDragon);
            m.Enqueue(netherDragon);
            m.Enqueue(illidanStormrage);
            return m;
            //if (m.Count == 0)
            //{
            //    reload = true;
            //}

        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }

        
    }
}
