using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    //Idea: Think of a game where there are many players, and whenever the game master says,
    //"Game over," all the players need to stop.The game master is like the "subject," and the players
    //are the "observers."
    //When the subject changes (game master says something), all observers get notified.
    internal class Observer
    {
    }


    public class GameMaster
    {
        private List<IPlayer> players = new List<IPlayer>();

        public void RegisterPlayer(IPlayer player)
        {
            players.Add(player);
        }

        public void GameOver()
        {
            foreach (var player in players)
            {
                player.StopPlaying();
            }
        }

    }

    public interface IPlayer
    {
        void StopPlaying();
    }

    public class Player : IPlayer
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            
        }

        public void StopPlaying()
        {
            Console.WriteLine($"Stop Playing Player : {Name}");
        }
    }



}
