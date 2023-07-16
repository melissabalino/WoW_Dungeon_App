using System.Reflection.Metadata;
using WoW_Dungeon_App;
using WoW_Signatures_Library;
using WoW_Descriptions_Library;

namespace WoW_Dungeon_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Signatures.Header("World of Warcraft: Burning Crusade");
            Descriptions.Introduction();
            #region Intro and Option to Play Game
            bool isPlaying = false;
            do
            {
                Console.WriteLine("1) Enter the Black Temple\n2) Quit");
                ConsoleKey choice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (choice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //TODO add in dungeon game play methods
                        Console.WriteLine("You have entered the dungeon.");
                        isPlaying = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Escape:
                        Descriptions.Quitter();
                        isPlaying = true;
                        return;
                    default:
                        Console.WriteLine("Input not recognized. Please try again.");
                        break;
                }

            } while (!isPlaying);
            #endregion

            #region Character/Player Creation
            //TODO create Monster Types
            //TODO create Player (Alliance or Horde)
            //TODO create Player Classses (Warlock, Warrior, etc...)
            //TODO create Weapons

            #endregion

            #region Main Game Loop

            #region Encounter Loop
            #endregion

            #endregion

            #region Room Generation
            #endregion

        }
    }
}