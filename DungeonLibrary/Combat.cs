using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_DungeonLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            int chance = attacker.CalcHitChance() - defender.CalcDodge();

            int roll = new Random().Next(1, 101);
            Thread.Sleep(300);
            if (roll <= chance)
            {
                int damage = attacker.CalcDamage();
                defender.Life -= damage;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{attacker.Name} attacked {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"\n{attacker.Name} missed!");
            }

        }

        public static bool DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
                return false;
            }       
            else
            {
                player.Score++;//
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou have slain {monster.Name}!");
                Console.ResetColor();
                return true;
            }
        }


    }
}
