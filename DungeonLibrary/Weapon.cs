using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WoW_DungeonLibrary
{
    public class Weapon
    {
        private string _name;
        private int _maxDamage;
        private int _minDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int MaxDamage
    {
        get { return _maxDamage; }
        set { _maxDamage = value; }
    }
    public int MinDamage
    {
        get { return _minDamage; }
        set
        {
            if (value <= MaxDamage)
            {
                _minDamage = value;
            }
            else
            {
                _minDamage = MaxDamage;
            }
        }
    }
    public int BonusHitChance
    {
        get { return _bonusHitChance; }
        set { _bonusHitChance = value; }
    }
    public bool IsTwoHanded
    {
        get { return _isTwoHanded; }
        set { _isTwoHanded = value; }
    }

    public WeaponType Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public Weapon() { }

    public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
    {
        Name = name;
        MinDamage = minDamage;
        MaxDamage = maxDamage;
        BonusHitChance = bonusHitChance;
        IsTwoHanded = isTwoHanded;
        Type = type;
    }
    public override string ToString()
        {
            return $"{Name}\n" +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Bonus Hit: {BonusHitChance}%\n" +
                   $"{(IsTwoHanded ? "Two" : "One")}-Handed {Type.ToString().Replace('_', ' ')}\n";
        }
}
