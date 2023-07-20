using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoW_DungeonLibrary;

namespace WoW_Dungeon_App
{
    internal class TestHarness
    {
        static void Main(string[] args)
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
