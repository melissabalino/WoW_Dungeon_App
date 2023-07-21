
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW_Descriptions_Library;

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
                   $"Description: \n\t{Description}\n" +
                   $"=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=";
        }

        public static Player PlayerOptions()
        {
            //Descriptions.DungeonEntrance();
            Console.WriteLine("Choose your Character:\n1) Eleanor Oakheart\n2) Victoria NightShade\n3) Widget Cogsworth\n4) Fizzle Quickspark\n5) Mortimer Darkbane\n6) Grimwald Shadowfang\n7) Kael'thas Emberblade\n8) Lor'themar Sunshard");
            char charChoice = Console.ReadKey(true).KeyChar;
            Console.Clear();
            switch (charChoice)
            {
                case '1':
                    return new HumanWarlock();
                    break;
                case '2':
                    return new HumanHunter();
                    break;
                case '3':
                    return new GnomeWarlock();
                    break;
                case '4':
                    return new GnomeHunter();
                    break;
                case '5':
                    return new UndeadWarlock();
                    break;
                case '6':
                    return new UndeadHunter();
                    break;
                case '7':
                    return new BloodElfWarlock();
                    break;
                case '8':
                    return new BloodElfHunter();
                    break;
                default:
                    return new GnomeHunter();
                    break;
            }
            HumanWarlock humanWarlock = new HumanWarlock();
            HumanHunter humanHunter = new HumanHunter();
            GnomeWarlock gnomeWarlock = new GnomeWarlock();
            GnomeHunter gnomeHunter = new GnomeHunter();
            UndeadWarlock undeadWarlock = new UndeadWarlock();
            UndeadHunter undeadHunter = new UndeadHunter();
            BloodElfWarlock bloodElfWarlock = new BloodElfWarlock();
            BloodElfHunter bloodElfHunter = new BloodElfHunter();
        }
    }
}


