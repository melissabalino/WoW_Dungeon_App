using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System;

namespace WoW_Descriptions_Library
{
    public class Descriptions
    {
        public static void Introduction()
        {
            Console.WriteLine("As you awaken in the Shadow Moon Valley, an otherworldly atmosphere immediately envelops you, tingling with arcane"); Thread.Sleep(3000);
            Console.WriteLine("power.  The pale glow of the mysterious Shadow Moon bathes the valley, casting an eerie light over rugged terrain"); Thread.Sleep(3000);
            Console.WriteLine("and jagged peaks that pierce the horizon.  The sky above is adorned with stars burning intensely, adding to the"); Thread.Sleep(3500);
            Console.WriteLine("foreboding feeling that ancient secrets and long-forgotten powers linger nearby.\n"); Thread.Sleep(5000);

            Console.WriteLine("Beneath your feet, the ground tells tales of past turmoil and conflict, bearing the weight of history.  Ethereal"); Thread.Sleep(3000);
            Console.WriteLine("foliage surrounds you, emitting a ghostly glow that guides your path through the darkness.  Sinister ruins remind you"); Thread.Sleep(3000);
            Console.WriteLine("of the valley's once powerful civilization, now lost in time.  Every rustle in the wind and flicker of shadow suggests"); Thread.Sleep(3500);
            Console.WriteLine("spectral forces guarding their secrets with ancient vigilance.\n"); Thread.Sleep(5000);

            Console.WriteLine("Your gaze shifts, and there it stands: THE BLACK TEMPLE.  Its imposing silhouette dominates the landscape, emanating "); Thread.Sleep(3000);
            Console.WriteLine("an aura of darkness and power.  Stark against the eerie backdrop of the Shadow Moon Valley, the temple evokes fear"); Thread.Sleep(3000);
            Console.WriteLine("and fascination, hinting at the formidable challenges within its ancient halls.  Its presence intertwines with the"); Thread.Sleep(3500);
            Console.WriteLine("valley's mystical allure, leaving you wondering about the enigmas and trials that await in this treacherous realm...\n"); Thread.Sleep(4000);
        }

        public static void Quitter()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Weakling! Those who lack the courage to face Illidan Stormrage shall find no mercy. The Burning Legion delights\nin the defeat of the feeble-hearted. Your surrender is an admission of your own insignificance.\nEmbrace your failure; it's too late to turn back now. For Azeroth's fate belongs to the bold, not to cowards.");
            Console.ResetColor();
        }

        public static void DungeonEntrance()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n'YOU ARE NOT PREPARED!'\n\n");
            Console.ResetColor();
            Console.WriteLine("A dark booming voice reverberates throughout the chambers of the hall.\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Illidan Stormrage:     'Your presence in the Black Temple surprises me.  You may have come this far,\n\t\t              but whether you possess the strength to survive what lies ahead remains to be seen...'\n\n\t\t\t\t'YOU ARE NOT PREPARED!'");
            Console.ResetColor();
            Console.WriteLine("=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=~-~=");
        }
    }
}