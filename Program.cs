using System;

class Program
{
    static void Main(string[] args)
    {
        // === Voice Greeting Placeholder ===
        Console.WriteLine("🔊 Voice greeting would play here if audio support was enabled.");

        // === ASCII Art Header ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
 
          /\_/\  
         ( o.o ) 
          > ^ < 
         (_w_w_)

                                   
        ");
        Console.ResetColor();

        // === Ask for Name & Personalized Greeting ===
        Console.Write("\n👋 Hello! What's your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Welcome, {name}! Let's chat about online safety. Type 'exit' to leave.\n");

        // === Simulated Chat ===
        while (true)
        {
            Console.Write($"{name}: ");
            string input = Console.ReadLine()?.ToLower() ?? "";

            if (input == "exit")
            {
                Console.WriteLine("Bot: Stay safe online! Goodbye. 👋");
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
