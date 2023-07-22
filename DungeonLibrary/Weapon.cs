using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class Weapon//parent
    {
        private string _name;
        private int _bonusHitChance;
        private int _minDamage;
        private int _maxDamage;
        private string _description;
        private WeaponTypes _type;
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int BonusHitChance { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public WeaponTypes Type { get; set; }
        public Weapon() { }
        public Weapon(string name, int bonusHitChance, int minDamage, int maxDamage, string description, WeaponTypes type)
        {
            Name = name;
            BonusHitChance = bonusHitChance;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            Type = type;
        }
        public override string ToString()
        {
            return $"\nEquipped Weapon: {Name}\t\t" +
                   $"Weapon Strength: {MinDamage} to {MaxDamage}\t" +
                   $"Weapon Bonus Hit Chance: {BonusHitChance}%\n\n" +
                   $"Weapon Description: The {Type} is a {Description}\n\n" +
                   $"=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=";


        }

        public static Weapon WeaponOptions()
        {
            Console.WriteLine("\nChoose your Weapon:\n\t1) Dagger\n\t2) Sword\n\t3) Staff\n\t4) Bow");
            char equippedWeapon = Console.ReadKey(true).KeyChar;
            Console.Clear();
            switch (equippedWeapon)
            {
                case '1':
                    Weapon dagger = new Weapon("Dagger", 5, 7, 12, "swift and agile weapon allowing for quick strikes and precise critical hits.", WeaponTypes.Dagger);
                    return dagger;
                    break;
                case '2':
                    Weapon sword = new Weapon("Sword", 5, 15, 25, "melee weapon providing a balance of speed, damage, and defensive capabilities.", WeaponTypes.Sword);
                    return sword;
                    break;
                case '3':
                    Weapon staff = new Weapon("Staff", 5, 5, 10, "magical weapon that enhances arcane powers and ability to channel potent spells.", WeaponTypes.Staff);
                    return staff;
                    break;
                case '4':
                    Weapon bow = new Weapon("Bow", 5, 15, 25, "weapon that offers high damage from a distance and grants the ability to attack \neenemies beyond melee range.", WeaponTypes.Bow);
                    return bow;
                    break;
                default:
                    Weapon defaultStaff = new Weapon("Staff", 5, 5, 10, "magical weapon that enhances arcane powers and ability to channel potent spells.", WeaponTypes.Staff);
                    return defaultStaff;
                    break;
            }
           
            
        }
        

    }
}
