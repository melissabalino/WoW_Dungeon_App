namespace WoW_Signatures_Library
{
    public class Signatures
    {
        public static void Header(string title)
        {
            Console.Title = title + "          ***** created by Melissa Balino *****";
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n" +
                              "=" + "                                                                                                                 =\n" +
                              "=                                             THE BLACK TEMPLE                                                    =\n" +
                              "=" + "                                                                                                                 =\n" +
                              "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        }

        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nAll code has finished. Press any key to terminate the program...");
            Console.ReadKey(true);
            Console.ResetColor();

        }
    }
}