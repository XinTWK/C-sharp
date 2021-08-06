using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EventAndMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem = new AudioSystem();
            // create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();
            // create two players and give them ID's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running....Press any key to end the game.");

            // pause
            Console.Read();

            // trigger the GameOver event
            GameEventManager.TriggerGameOver();



        }
    }
}
