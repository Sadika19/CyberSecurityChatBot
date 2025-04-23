using System;
using System.Media;
using System.Threading;

class Program
{
    static void TypeEffect(string message, int delay = 40)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        
        {
          
        }

        // === ASCII Art Header ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
        /\_/\           ____  
       ( o.o )         |__  | 
        > ^ <         |___| | Cybersecurity CatBot
        ");
        Console.ResetColor();

        // === Ask User for Name ===
        Console.Write("\nPlease enter your name: ");
        string userName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        TypeEffect($"\nWelcome {userName}! Let's chat about online safety. Type 'exit' to leave.\n");
        Console.ResetColor();

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine()?.ToLower() ?? "";

            if (string.IsNullOrWhiteSpace(input))
            {
                TypeEffect("Bot: I didn’t quite understand that. Could you rephrase?");
            }
            else if (input.Contains("exit"))
            {
                TypeEffect("Bot: Stay safe online! Goodbye.");
                break;
            }
            else if (input.Contains("password"))
            {
                TypeEffect("Bot: Use strong and unique passwords for every account.");
            }
            else if (input.Contains("phishing"))
            {
                TypeEffect("Bot: Phishing emails pretend to be legit. Never click suspicious links!");
            }
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                TypeEffect("Bot: Two-factor authentication helps protect your accounts. Always enable it.");
            }
            else if (input.Contains("safe") || input.Contains("online"))
            {
                TypeEffect("Bot: Keep your software updated and use antivirus tools.");
            }
            else if (input.Contains("how are you"))
            {
                TypeEffect("Bot: I'm doing well, thank you! I'm here to help keep you safe online.");
            }
            else if (input.Contains("purpose"))
            {
                TypeEffect("Bot: I'm your Cybersecurity Awareness Bot. I provide online safety tips.");
            }
            else if (input.Contains("what can i ask") || input.Contains("help"))
            {
                TypeEffect("Bot: You can ask about password safety, phishing, 2FA, or safe browsing.");
            }
            else
            {
                TypeEffect("Bot: Try asking about passwords, phishing, 2FA, or online safety.");
            }
        }
    }
}
