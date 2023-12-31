﻿namespace WoW_DungeonLibrary
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

        public string Name { get; set; }
        

        public int HitChance { get; set; }
       

        public int Dodge { get; set; }
        

        public int MaxLife { get; set; }
       

        public int Life
        {
            get { return _life; }
            set { _life = (value <= MaxLife ? value : MaxLife);}
        }
 
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
            return $"\n=~-~=~-~=~-~=~-~=~-~=~-~= {Name} =~-~=~-~=~-~=~-~=~-~=~-~=\n\n" +
                   $"Health: {Life} out of {MaxLife}\t\t" +
                   $"HitChance: {HitChance}%\t\t\t" +
                   $"Dodge: {Dodge}%\n\n";
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