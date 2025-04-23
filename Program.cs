using System;
using System.Media;

class Program
{
    static void Main(string[] args)
    {

        // === ASCII Art Header ===
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
 /\     /\
{  `---'  }
{  O   O  }
~~>  V  <~~
 \  \|/  /
  `-----'____
 /     \    \_
{       }\  )_\_   Cybersecurity Awareness Chatbot
|  \_/  |/ /  \_\  
 \__/  /(_/     \  
   (__/
        ");
        Console.ResetColor();

        // === Text-Based Greeting ===
        Console.Write("Bot: Welcome! What's your name? ");
        string userName = Console.ReadLine();
        Console.WriteLine($"\nBot: Hello, {userName}! Let’s chat about online safety. Type 'exit' to leave.\n");

        // === Simulated Chat with Basic Responses ===
        while (true)
        {
            Console.Write($"{userName}: ");
            string input = Console.ReadLine()?.ToLower() ?? "";

            if (input == "exit")
            {
                Console.WriteLine("Bot: Stay safe online! Goodbye :)");
                break;
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I'm running smooth and secure, thanks for asking!");
            }
            else if (input.Contains("your purpose") || input.Contains("what do you do"))
            {
                Console.WriteLine("Bot: I'm here to raise cybersecurity awareness and help you stay safe online.");
            }
            else if (input.Contains("what can i ask") || input.Contains("topics"))
            {
                Console.WriteLine("Bot: You can ask me about password safety, phishing, 2FA, safe browsing, and more.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong and unique passwords for every account.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing emails often look real. Never click suspicious links!");
            }
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                Console.WriteLine("Bot: Always enable two-factor authentication to secure your accounts.");
            }
            else if (input.Contains("safe") || input.Contains("online"))
            {
                Console.WriteLine("Bot: Keep your software updated and use antivirus tools.");
            }
            else
            {
                Console.WriteLine("Bot: Try asking about passwords, phishing, 2FA, or online safety!");
            }
        }
    }
}
