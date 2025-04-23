using System;
using System.Media;

class Program
{
    static void Main(string[] args)
    {
        // === Voice Greeting ===
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();  // or Play() for async
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error: " + ex.Message);
        }


        // === ASCII Art Header ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
   ____            _                  _         _       
  / ___|___  _ __ | |_ ___  _ __ ___ (_)___ ___| |_ ___ 
 | |   / _ \| '_ \| __/ _ \| '_ ` _ \| / __/ __| __/ __|
 | |__| (_) | | | | || (_) | | | | | | \__ \__ \ |_\__ \
  \____\___/|_| |_|\__\___/|_| |_| |_|_|___/___/\__|___/
        ");
        Console.ResetColor();

        // === Simulated Chat ===
        Console.WriteLine("\nLet's chat about online safety. Type 'exit' to leave.\n");

        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine()?.ToLower() ?? "";


            if (input == "exit")
            {
                Console.WriteLine("Bot: Stay safe online! Goodbye.");
                break;
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong and unique passwords for every account.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing emails pretend to be legit. Never click suspicious links!");
            }
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                Console.WriteLine("Bot: Two-factor authentication helps protect your accounts. Always enable it.");
            }
            else if (input.Contains("safe") || input.Contains("online"))
            {
                Console.WriteLine("Bot: Keep your software updated and use antivirus tools.");
            }
            else
            {
                Console.WriteLine("Bot: Try asking about passwords, phishing, 2FA, or online safety.");
            }
        }
    }
}
