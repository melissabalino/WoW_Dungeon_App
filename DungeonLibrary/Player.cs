
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class Player : Character
    {
        private string _faction;
        private string _race;
        private string _playerClass;
        private bool _isEnhanced;
        private string _description;


        public string Faction { get; set; }
        public string Race { get; set; }
        public string PlayerClass { get; set; }
        public bool IsEnhanced { get; set; }
        public string Description { get; set; }

        public Player() { }

        public Player(string name, int hitChance, int dodge, int maxLife, string faction, string race, string playerClass, bool isEnhanced, string description) : base(name, 75, 50, 100)
        {
            Faction = faction;
            Race = race;
            PlayerClass = playerClass;
            IsEnhanced = isEnhanced;
            Description = description;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"Faction: {Faction}\n" +
                   $"Race: {Race}\n" +
                   $"Class: {PlayerClass}\n" +
                   $"{(IsEnhanced ? "Enhanced Heroism: +10 power" : "No Enhanced Heroism")}\n"+
                   $"Description: \n{Description}";
        }

        public static void PlayerSelection()
        {
            HumanWarlock humanWarlock = new HumanWarlock();
            Console.WriteLine(humanWarlock);

            HumanHunter humanHunter = new HumanHunter();
            Console.WriteLine(humanHunter);

            GnomeWarlock gnomeWarlock = new GnomeWarlock();
            Console.WriteLine(gnomeWarlock);

            GnomeHunter gnomeHunter = new GnomeHunter();
            Console.WriteLine(gnomeHunter);

            UndeadWarlock undeadWarlock = new UndeadWarlock();
            Console.WriteLine(undeadWarlock);

            UndeadHunter undeadHunter = new UndeadHunter();
            Console.WriteLine(undeadHunter);

            BloodElfWarlock bloodElfWarlock = new BloodElfWarlock();
            Console.WriteLine(bloodElfWarlock);

            BloodElfHunter bloodElfHunter = new BloodElfHunter();
            Console.WriteLine(bloodElfHunter);
        }
    }
}


