using System.Reflection.Metadata;
using WoW_Dungeon_App;
using WoW_Signatures_Library;
using WoW_Descriptions_Library;
using WoW_DungeonLibrary;
using System.Threading;
using System.Numerics;
using System.Xml.Linq;

namespace WoW_Dungeon_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Signatures.Header("World of Warcraft: Burning Crusade");
            //       mDescriptions.Introduction();
            #region Character/Player Creation
            //TODO create Monster Types

            #endregion

            #region Intro and Option to Play Game
            bool isPlaying = false;
            do
            {
                Console.WriteLine("\nChoose your Path:\n\t1) Explore the Black Temple\n\t2) Flee");
                ConsoleKey choice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (choice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Descriptions.DungeonEntrance();
                        Player player = Player.PlayerOptions();
                        player.EquippedWeapon = Weapon.WeaponOptions();
                        Queue<Monster> monsters = Monster.GetMonsters();
                        #region Main Game Loop
                        bool exit = false;
                        do
                        {
                            //TODO create a monster
                            Monster monster = monsters.Dequeue();

                            Console.WriteLine(GetRoom() + $"Suddenly, you catch the attention of a {monster.Name} as it runs to attack you!");
                            #region Encounter Loop
                            bool reload = false;
                            do
                            {
                                #region Menu
                                Console.WriteLine("\nPlease choose an action:\n\t" +
                                      "A) Attack\n\t" +
                                      //"R) Run Away\n\t" +
                                      "P) Player Info\n\t" +
                                      "M) Monster Info\n\t" +
                                      "E) Exit\n");
                                ConsoleKey selection = Console.ReadKey(true).Key;
                                Console.Clear();
                                switch (selection)
                                {
                                    case ConsoleKey.A:

                                        reload = Combat.DoBattle(player, monster);
                                        /*Unhandled exception. System.InvalidOperationException: Queue empty.
                                        at System.Collections.Generic.Queue`1.ThrowForEmptyQueue()
   at System.Collections.Generic.Queue`1.Dequeue()
   at WoW_Dungeon_App.Program.Main(String[] args) in C: \Users\Student\Documents\Visual Studio 2022\Projects\03_CSF2\WoW_Dungeon_App\WoW_Dungeon_App\Program.cs:l
                                        */
                                        break;

                                    //case ConsoleKey.R:
                                    //    Console.WriteLine($"\nRun Away! {monster.Name} attacks you as you flee.\n");

                                    //    //Combat.DoAttack(monster, player);
                                    //    reload = true;//"reload" the monster and the room
                                    //    break;
                                    case ConsoleKey.P:
                                        Console.WriteLine(player);
                                        break;
                                    case ConsoleKey.M:
                                        Console.WriteLine(monster);
                                        break;
                                    case ConsoleKey.E:
                                    case ConsoleKey.Escape:
                                    case ConsoleKey.X:
                                        Descriptions.Quitter();
                                        exit = true;
                                        break;
                                    default:
                                        Console.WriteLine("Aye, that choice be invalid. Try again, adventurer.");
                                        //testing only
                                        //player.Life += 100;
                                        break;
                                }//end switch

                                if (player.Life <= 0)
                                {
                                    Console.WriteLine("Death conquers all...");
                                    exit = true;
                                }

                                #endregion
                            } while (!reload && !exit);
                            #endregion
                        } while (!exit);
                        #endregion

                        isPlaying = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.Escape:
                        Descriptions.Quitter();
                        isPlaying = true;
                        return;
                    default:
                        Console.WriteLine("Aye, that choice be invalid. Try again, adventurer.");
                        break;
                }

            } while (!isPlaying);
            #endregion


        }
        #region Room Generation
        private static string GetRoom()
        {
            string[] rooms =
            {
                 "\n\nWhile exploring, you enter the Temple Summit at the apex of the Black Temple.  A towering statue of Illidan Stormrage gazes menacingly \nupon a dimly lit chamber, surrounded by ancient altars and demon-themed tapestries that accentuate the \nroom's dark and foreboding atmosphere.\n",
                 "\n\nYou enter the Halls of Anguish which is a desolate, labyrinth expanse filled with blood-stained chains and grotesque demon \nconstructs, where sorrowful wails echo through the cold stone walls, evoking a sense of haunting torment and despair.\n",
                 "\n\nYou continue onwards to the Warden's Cage, an eerie, prison-like chamber, where ethereal blue light casts an otherworldly glow upon \nMaiev Shadowsong's confinement.  Her spectral form is surrounded by a circle of eternal flames, emphasizing her \neternal pursuit of Illidan.\n",
                 "\n\nJourneying into the Sanctum of the Chosen, you witness a beautifully adorned, yet ominous sanctuary adorned with dark banners and intricate \ndemon-themed artwork, reflecting the zeal and loyalty of Illidan's most fervent followers.\n",
                 "\n\nWhile exploring the Halls of Vaillance, you are met with a grand, majestic hall adorned with illustrious banners and stone statues, capturing \nthe echoes of countless battles fought within its sacred space, exuding an air of honor and glory.\n",
                 "\n\nYou enter the Temple's Library, an ancient repository of arcane knowledge, filled with towering bookshelves and dimly \nlit alcoves, where eldritch tomes and artifacts emanate an aura of forbidden secrets guarded by \never-vigilant demonic sentinels.\n",
                 "\n\nYou come across the Refectory, an infernal kitchen dominated by massive cooking apparatuses and bubbling cauldrons, where the \nscorching heat and sizzling sound of demonic cuisine add to the ambiance of this culinary inferno.\n",
                 "\n\nYou continue onwards towards the Reliquary of Souls, a haunting, ethereal realm where the captured spirits of fallen champions are trapped \nin luminous orbs, floating within an oppressive void, creating an unsettling and somber spectacle.\n",
                 "\n\nJourneying into the Black Temple Summit, you stand on a perilous platform enveloped in a swirling tempest, suspended high above the main entrance, \nwith fierce winds and precarious footing adding to the intensity of the challenge presented by Illidan's\nelite guardians.\n",
                 "\n\nYou enter the Shrine of Lost Souls, a dimly lit, sepulchral chamber housing ghostly apparitions, memorialized by \nstatues and memorial stones, signifying the everlasting devotion of Illidan's most loyal followers, now risen \nas spectral guardians.\n",
                 "\n\nWhile exploring, you enter the Den of Mortal Delights and are met with an opulent, yet deceptive chamber adorned with lush tapestries and captivating illusions, \nmasking the malevolent succubi that tempt and ensnare the unwary with promises of pleasure and pain.\n",
                 "\n\nJourneying into the Chamber of Command, a sanctified meeting place, you see many ominous dark crystals and insidious runes, \ndepicting Illidan's lieutenants, the demon council, as they gather to discuss strategies and further their master's dark designs.\n",
                 "\n\nYou've stumbled upon the innermost chamber, an enigmatic realm with ethereal floating platforms \nand celestial energy, serving as the climactic battleground where players face Illidan Stormrage in a titanic \nconfrontation between light and darkness.\n"
            };
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;

        }
        #endregion
    }
}