using System;
using System.Diagnostics;
using System.Media;
using System.Threading;

class Program
{
    // Simulates typing effect
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
        // === Voice Greeting (Cross-platform) ===
        try
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "greeting.wav");
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(filePath)
                {
                    UseShellExecute = true
                }
            };
            process.Start();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error: " + ex.Message);
        }


        // === ASCII CatBot Logo ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
      /\_/\  
     ( o.o )    CYBERSECURITY CATBOT
      > ^ <     Stay Safe Online!
     (_w_w_)
=========================================
");
        Console.ResetColor();

        // === Personalized Greeting ===
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        TypeEffect($"\nWelcome {userName}! Let's chat about staying safe online.\n");
        Console.ResetColor();

        // === Chat Instructions ===
        Console.WriteLine("Type your questions below (e.g., 'passwords', '2FA', 'phishing', etc.)");
        Console.WriteLine("Type 'exit' to leave.\n");
        Console.WriteLine("=========================================\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("You: ");
            string input = Console.ReadLine()?.ToLower().Trim() ?? "";
            Console.ResetColor();

            if (input == "exit")
            {
                TypeEffect("Bot: Stay safe online! Goodbye.");
                break;
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                TypeEffect("Bot: I didn’t quite understand that. Could you rephrase?");
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
                TypeEffect("Bot: Two-factor authentication protects your accounts. Always enable it.");
            }
            else if (input.Contains("safe") || input.Contains("online"))
            {
                TypeEffect("Bot: Keep software updated and use antivirus tools.");
            }
            else if (input.Contains("how are you"))
            {
                TypeEffect("Bot: I'm doing well, thank you! I'm here to keep you safe online.");
            }
            else if (input.Contains("purpose"))
            {
                TypeEffect("Bot: I'm your Cybersecurity Awareness Bot. I provide tips to stay secure.");
            }
            else if (input.Contains("what can i ask") || input.Contains("help"))
            {
                TypeEffect("Bot: You can ask about password safety, phishing, 2FA, or safe browsing.");
            }
            else
            {
                TypeEffect("Bot: Hmm, I didn't quite catch that. Could you ask about something like 'passwords' or '2FA'?");
            }

            Console.WriteLine("\n-----------------------------------------\n");
        }
    }
}
