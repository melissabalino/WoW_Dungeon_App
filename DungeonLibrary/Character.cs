﻿namespace DungeonLibrary
{
    public abstract class Character
    {
        //FIELDS

        private string _name;
        private int _hitChance;
        private int _dodge;
        private int _maxLife;
        private int _life;

        //PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Dodge
        {
            get { return _dodge; }
            set { _dodge = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }
 
        //Default CTOR
        public Character() { }

        //FQ CTOR
        public Character(string name, int hitChance, int dodge, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Dodge = dodge;
            MaxLife = maxLife;
            Life = MaxLife = maxLife;
        }

        //METHODS
        public override string ToString()
        {
            return $"----{Name}----\n" +
                   $"Life: {Life} out of {MaxLife}\n" +
                   $"Hit Chance: {HitChance}\n" +
                   $"Dodge: {Dodge}%\n";
        }

        public virtual int CalcDodge()
        {
            return Dodge;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }
      
        public abstract int CalcDamage();

    }
}