using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

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
            Monster m4 = new Monster("Plague Bear", 50, 25, 25, 10, 7, "A corrupted and diseased bear, spreading pestilence wherever it roams.");
            Monster m5 = new Monster("Frost Fire Basilisk", 50, 25, 25, 10, 7, "A reptilian creature embodying both icy and fiery elements, known for its deadly breath.");
            Monster m6 = new Monster("Shadowcaster", 50, 25, 25, 10, 7, "An elusive spellcaster adept at manipulating shadows and weaving dark magic.");
            Monster m7 = new Monster("Abyss Serpent", 50, 25, 25, 10, 7, "A serpentine behemoth dwelling in the darkest depths of the ocean, luring ships to their doom.");
            Monster m8 = new Monster("Fire Dragon", 50, 25, 25, 10, 7, "A mighty and fearsome dragon, wreathed in flames and capable of laying waste to entire landscapes.");
            Monster m9 = new Monster("Frost Dragon", 50, 25, 25, 10, 7, " A majestic dragon, wielding the power of ice to freeze its foes in their tracks.");
            Monster m10 = new Monster("Nether Dragon", 50, 25, 25, 10, 7, "An otherworldly dragon, hailing from the Twisting Nether and wielding arcane energies beyond mortal comprehension.");

            Direwolf wolf = new Direwolf();
            WastewanderBandit bandit = new WastewanderBandit();
            GhostlySteward ghost = new GhostlySteward();
            //List<Monster> monsters = new()
            //{
            //    direwolf,
            //    wastewanderBandit,
            //    ghostlySteward,

            //};
            //int index = new Random().Next(monsters.Count);
            //return monsters[index];
           
          
            Queue<Monster> m = new Queue<Monster>();
            m.Enqueue(direwolf);
            m.Enqueue(wastewanderBandit);
            m.Enqueue(ghostlySteward);
            m.Enqueue(m4);
            m.Enqueue(m5);
            m.Enqueue(m6);
           
            return m;

        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
