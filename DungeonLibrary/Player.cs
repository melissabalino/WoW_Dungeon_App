
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }

        public Player() { }

        public Player(string name, int hitChance, int dodge, int maxLife, string faction, string race, string playerClass, bool isEnhanced, Weapon equippedWeapon, string description) : base(name, 75, 50, 100)
        {
            Faction = faction;
            Race = race;
            PlayerClass = playerClass;
            IsEnhanced = isEnhanced;
            EquippedWeapon = equippedWeapon;
            Description = description;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"{(IsEnhanced ? "Enhanced Heroism: +10 attack power" : "No Enhanced Heroism")}\n\n" +
                   $"Faction: {Faction}\t\t" +
                   $"Race: {Race}\t\t\t" +
                   $"Class: {PlayerClass}\n\n" +
                   $"Description: {Description}\n\n" +
                   $"=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=\n" +
                   $"{EquippedWeapon}";
        }

        public static Player PlayerOptions()
        {

            Console.WriteLine("\nChoose your Character:\n\t1) Eleanor Oakheart\n\t2) Victoria NightShade\n\t3) Widget Cogsworth\n\t4) Fizzle Quickspark\n\t5) Mortimer Darkbane\n\t6) Grimwald Shadowfang\n\t7) Kael'thas Emberblade\n\t8) Lor'themar Sunshard");
            char charChoice = Console.ReadKey(true).KeyChar;
            Console.Clear();
            switch (charChoice)
            {
                case '1':
                    Descriptions.DungeonEntrance();
                    return new HumanWarlock();
                    break;
                case '2':
                    Descriptions.DungeonEntrance();
                    return new HumanWarrior();
                    break;
                case '3':
                    Descriptions.DungeonEntrance();
                    return new GnomeWarlock();
                    break;
                case '4':
                    Descriptions.DungeonEntrance();
                    return new GnomeWarrior();
                    break;
                case '5':
                    Descriptions.DungeonEntrance();
                    return new UndeadWarlock();
                    break;
                case '6':
                    Descriptions.DungeonEntrance();
                    return new UndeadWarrior();
                    break;
                case '7':
                    Descriptions.DungeonEntrance();
                    return new BloodElfWarlock();
                    break;
                case '8':
                    Descriptions.DungeonEntrance();
                    return new BloodElfWarrior();
                    break;
                default:
                    Descriptions.DungeonEntrance();
                    return new GnomeWarrior();
                    break;
            }
            HumanWarlock humanWarlock = new HumanWarlock();
            HumanWarrior humanHunter = new HumanWarrior();
            GnomeWarlock gnomeWarlock = new GnomeWarlock();
            GnomeWarrior gnomeHunter = new GnomeWarrior();
            UndeadWarlock undeadWarlock = new UndeadWarlock();
            UndeadWarrior undeadHunter = new UndeadWarrior();
            BloodElfWarlock bloodElfWarlock = new BloodElfWarlock();
            BloodElfWarrior bloodElfHunter = new BloodElfWarrior();

        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            int bonusDamage = 0;
            if (IsEnhanced)
            {
                bonusDamage = 10;
                Console.WriteLine("Your Warlock ability enhanced your attack power.");
            }
            return damage + bonusDamage;
        }
        public override int CalcHitChance()
        {
            return base.CalcDodge() + EquippedWeapon.BonusHitChance;
        }
        //Random rand = new Random();
        //int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage);
        //if (IsEnhanced)
        //{
        //    return damage + 10;
        //}
        //else return damage;

    }
}


