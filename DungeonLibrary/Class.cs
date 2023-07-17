using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WoW_DungeonLibrary
{
   public class Class : Character
    {
        public ClassTypes PlayerClass { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Class(string name, ClassTypes playerClass, Weapon equippedWeapon)
            : base(name, 70, 5, 40)
        {
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            switch (PlayerClass)
            {

            }


        }
        
        




    }
}
