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
            return "=-=-=-= Monster =-=-=-=\n" +
                   base.ToString() +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Description: {Description}\n";
        }
        public static Monster GetMonster()
        {
            Direwolf direwolf = new Direwolf("Direwolf", 15, 25, 25, 10, 7, "A fierce and formidable wolf, renowned for its strength and hunting prowess.\n", 50);
            WastewanderBandit wastewanderBandit = new WastewanderBandit("Wastewander Bandit", 15, 25, 25, 12, 7, "A cunning and elusive desert outlaw, preying on unsuspecting travelers in arid regions.", 50);
            Monster m3 = new Monster("Ghostly Steward", 20, 25, 25, 5, 2, "An ethereal servant bound to a haunted estate, forever carrying out its spectral duties.");
            Monster m4 = new Monster("Plague Bear", 20, 25, 25, 6, 2, "A corrupted and diseased bear, spreading pestilence wherever it roams.");
            Monster m5 = new Monster("Frost Fire Basilisk", 20, 25, 25, 7, 3, "A reptilian creature embodying both icy and fiery elements, known for its deadly breath.");
            Monster m6 = new Monster("Shadowcaster", 30, 25, 25, 8, 3, "An elusive spellcaster adept at manipulating shadows and weaving dark magic.");
            Monster m7 = new Monster("Abyss Serpent", 35, 25, 25, 8, 4, "A serpentine behemoth dwelling in the darkest depths of the ocean, luring ships to their doom.");
            Monster m8 = new Monster("Fire Dragon", 40, 25, 25, 9, 5, "A mighty and fearsome dragon, wreathed in flames and capable of laying waste to entire landscapes.");
            Monster m9 = new Monster("Frost Dragon", 40, 25, 25, 9, 5, " A majestic dragon, wielding the power of ice to freeze its foes in their tracks.");
            Monster m10 = new Monster("Nether Dragon", 45, 25, 25, 10, 5, "An otherworldly dragon, hailing from the Twisting Nether and wielding arcane energies beyond mortal comprehension.");

            Direwolf wolf = new Direwolf();
            WastewanderBandit bandit = new WastewanderBandit();
            List<Monster> monsters = new()
        {
            direwolf,
            wolf,
            wastewanderBandit,
            bandit,
        };
            int index = new Random().Next(monsters.Count);
            return monsters[index];
        }//how to 
    }
}
