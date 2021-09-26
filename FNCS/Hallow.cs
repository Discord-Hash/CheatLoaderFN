

using Hallow;
using System;
using System.Threading;

namespace Hallow
{
    internal class Hallow
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Hallow2.system();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Hallow2.Print("discord.gg/UtEVbKsqXf", 30); 
            Thread.Sleep(700);
            Console.Clear();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.WriteLine(@"                   
██╗░░██╗░█████╗░██╗░░░░░██╗░░░░░░█████╗░░██╗░░░░░░░██╗  ██╗░░░██╗░░███╗░░░░░░█████╗░
██║░░██║██╔══██╗██║░░░░░██║░░░░░██╔══██╗░██║░░██╗░░██║  ██║░░░██║░████║░░░░░██╔══██╗
███████║███████║██║░░░░░██║░░░░░██║░░██║░╚██╗████╗██╔╝  ╚██╗░██╔╝██╔██║░░░░░██║░░██║
██╔══██║██╔══██║██║░░░░░██║░░░░░██║░░██║░░████╔═████║░  ░╚████╔╝░╚═╝██║░░░░░██║░░██║
██║░░██║██║░░██║███████╗███████╗╚█████╔╝░░╚██╔╝░╚██╔╝░  ░░╚██╔╝░░███████╗██╗╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░  ░░░╚═╝░░░╚══════╝╚═╝░╚════╝░  
                                                                ");
            Console.ForegroundColor = ConsoleColor.Red;
            Hallow2.system();
            Console.WriteLine(" ");
            
            Hallow2.Print("discord.gg/UtEVbKsqXf", 50);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            Hallow2.Print("\n Press Enter to inject.");
            Console.ReadLine();
            Hallow1.Inject();
            Hallow2.Print("\n\nClosing Application", 40);
            Thread.Sleep(500);
            Environment.Exit(-1);
        }
    }
}
