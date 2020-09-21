using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        //member variables
        Player playerOne;
        Player playerTwo;

        //constructor
        public Game()
        {
            playerOne = new Human();
        }

        //member methods

        public void ChooseGameMode()
        {
            //This needs validation
            Console.WriteLine("If you want to play the Computer, type 1." + "\n");
            Console.WriteLine("If you want to play a friend, type 2.");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    playerTwo = new AI();
                    break;
                case "2":
                    playerTwo = new Human();
                    break;
                default:
                    break;
            }
        }


        public void RunGame()
        {
            GameIntro gameIntro = new GameIntro();
            gameIntro.DisplayIntro();
            //Choose game type - PvP or PvComputer
            ChooseGameMode();
            //Optional setup - Enter player names?

            //Gameplay Rounds Section
            //Display current state of game points
            //Display gesture options
            //Player One Chooses a gesture
            //Display gesture options
            //Player Two Chooses a gesture
            //Compare the gestures, decide who wins, winner gets a point
            //Display outcome of round
            //Utilize a check on points to see if we need another round


            //EndGame/Victory Section
            //Display winner of game
            //Optionally prompt for a new game


        }

        //Do we want a Round/Battle class?
        //Do we want a Gesture class?
        //Choosing a Gesture - override a method for player or computer?
        //Players need a point variable
        //Players need a list of gestures
        //Players need a "chosen gesture" variable
    }
}
