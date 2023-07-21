using System.Reflection.Metadata;
using WoW_Dungeon_App;
using WoW_Signatures_Library;
using WoW_Descriptions_Library;
using WoW_DungeonLibrary;
using System.Threading;
using System.Numerics;

namespace WoW_Dungeon_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Signatures.Header("World of Warcraft: Burning Crusade");
            //Descriptions.Introduction();
            #region Character/Player Creation
           
            
            //player.EquippedWeapon = whatever weapon they picked
            //TODO create Weapons
            //TODO create Monster Types

            #endregion

            #region Intro and Option to Play Game
            bool isPlaying = false;
            do
            {
                Console.WriteLine("\nChoose your Path:\n1) Explore the Black Temple\n2) Flee");
                ConsoleKey choice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (choice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Descriptions.DungeonEntrance();
                        Player player = Player.PlayerOptions();
                        #region Main Game Loop
                        bool exit = false;
                        do
                        {
                            //TODO create a monster
                            Monster monster = Monster.GetMonster();
                            //TODO generate a room
                            Console.WriteLine(GetRoom() + $"\nSuddenly, you see a {monster.Name}!");
                            #region Encounter Loop
                            bool reload = false;
                            do
                            {
                                #region Menu
                                Console.WriteLine("\nPlease choose an action:\n\t" +
                                      "A) Attack\n\t" +
                                      "R) Run Away\n\t" +
                                      "P) Player Info\n\t" +
                                      "M) Monster Info\n\t" +
                                      "E) Exit\n");
                                // capture user selection
                                ConsoleKey selection = Console.ReadKey(true).Key;
                                //Clear the console
                                Console.Clear();
                                switch (selection)
                                {
                                    case ConsoleKey.A:
                                        Console.WriteLine("ATTACK!!!\n\n");
                                        //reload = Combat.DoBattle(player, monster);
                                        break;

                                    case ConsoleKey.R:
                                        Console.WriteLine($"\nRun Away! {monster.Name} attacks you as you flee.\n");
                                        
                                        //Combat.DoAttack(monster, player);
                                        reload = true;//"reload" the monster and the room
                                        break;

                                    case ConsoleKey.P:
                                        //Console.WriteLine("Player Info: ");
                                        Console.WriteLine(player);
                                        break;

                                    case ConsoleKey.M:
                                        //Console.WriteLine("Monster Info: ");
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

                                //if (player.Life <= 0)
                               // {
                               //     Console.WriteLine("Death conquers all.");
                               //     exit = true;
                               // }

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
                "The Temple Summit: At the apex of the Black Temple, a towering statue of Illidan Stormrage gazes menacingly \nupon a dimly lit chamber, surrounded by ancient altars and demon-themed tapestries that accentuate the \nroom's dark and foreboding atmosphere.\n",
                 "The Halls of Anguish: A desolate, labyrinthine expanse filled with blood-stained chains and grotesque demon \nconstructs, where sorrowful wails echo through the cold stone walls, evoking a sense of haunting torment and despair.\n",
                 "The Warden's Cage: An eerie, prison-like chamber, where ethereal blue light casts an otherworldly glow upon \nMaiev Shadowsong's confinement, her spectral form surrounded by a circle of eternal flames, emphasizing her \neternal pursuit of Illidan.\n",
                 "The Sanctum of the Chosen: A beautifully adorned, yet ominous sanctuary adorned with dark banners and intricate \ndemon-themed artwork, reflecting the zeal and loyalty of Illidan's most fervent followers.\n",
                 "The Halls of Vaillance: A grand, majestic hall adorned with illustrious banners and stone statues, capturing \nthe echoes of countless battles fought within its sacred space, exuding an air of honor and glory.\n",
                 "The Temple's Library: An ancient repository of arcane knowledge, filled with towering bookshelves and dimly lit \nalcoves, where eldritch tomes and artifacts emanate an aura of forbidden secrets guarded by \never-vigilant demonic sentinels.\n",
                 "The Refectory: An infernal kitchen dominated by massive cooking apparatuses and bubbling cauldrons, where the \nscorching heat and sizzling sound of demonic cuisine add to the ambiance of this culinary inferno.\n",
                 "The Reliquary of Souls: A haunting, ethereal realm where the captured spirits of fallen champions are trapped \nin luminous orbs, floating within an oppressive void, creating an unsettling and somber spectacle.\n",
                 "The Black Temple Summit: A perilous platform enveloped in a swirling tempest, suspended high above the main entrance, \nwith fierce winds and precarious footing adding to the intensity of the challenge presented by Illidan's\nelite guardians.\n",
                 "The Shrine of Lost Souls: A dimly lit, sepulchral chamber housing ghostly apparitions, memorialized by statues \nand memorial stones, signifying the everlasting devotion of Illidan's most loyal followers, now risen \nas spectral guardians.\n",
                 "The Den of Mortal Delights: An opulent, yet deceptive chamber adorned with lush tapestries and captivating illusions, \nmasking the malevolent succubi that tempt and ensnare the unwary with promises of pleasure and pain.\n",
                 "The Chamber of Command: A sanctified meeting place, featuring ominous dark crystals and insidious runes, \nwhere Illidan's lieutenants, the demon council, gather to discuss strategies and further their master's dark designs.\n",
                 "The Temple Summit - Black Temple: The innermost chamber, an enigmatic realm with ethereal floating platforms \nand celestial energy, serving as the climactic battleground where players face Illidan Stormrage in a titanic \nconfrontation between light and darkness.\n"
            };
            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            string room = rooms[index];
            return room;

        }
        #endregion
    }
}