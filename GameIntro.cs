using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameIntro
    {
        public void DisplayIntro()
        {


            //Intro Section
            //Greeting/Welcome
            Console.WriteLine("Welcome to Rock, Paper Scissors, Lizard, Spock!" + "\n" + "\n" + "Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            //Rules

            Console.WriteLine("The object of the game is to beat your opponent by choosing a hand gesture that will beat the option they choose.");
            Console.WriteLine("\n" + "Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("The Rules to the game are simple." + "\n" + "\n");
            Console.WriteLine("Rock crushes Scissors" + "\n");
            Console.WriteLine("Scissors cuts Paper" + "\n");
            Console.WriteLine("Paper will cover Rock" + "\n");
            Console.WriteLine("Rock will crush Lizard" + "\n");
            Console.WriteLine("Lizard will poison Spock" + "\n");
            Console.WriteLine("Spock smashes Scissors" + "\n");
            Console.WriteLine("Scissors will decapitate Lizard" + "\n");
            Console.WriteLine("Lizard eats Paper" + "\n");
            Console.WriteLine("Paper disproves Spock" + "\n");
            Console.WriteLine("And finally" + "\n");
            Console.WriteLine("Spock vaporizes Rock" + "\n" + "\n");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("First player to win two rounds, wins the game, and will recieve five million dollars!");

            Console.WriteLine("\n" + "Press Enter if you are ready to play!");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
