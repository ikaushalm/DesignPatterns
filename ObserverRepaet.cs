using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ObserverRepaet
    {
    }

    public interface IGamer
    {
        void StopPlaying();
    }


    public class Gamer : IGamer
    {
        public string Name { get; set; }

        public Gamer(string name)
        {
            Name = name;
        }
        public void StopPlaying()
        {
            Console.WriteLine($"Player are  stopping to play {Name}");
        }
    }


    public class GameMaster1
    {
        List<IGamer> gamers = new List<IGamer>();

        public void Addgamer(Gamer gamer)
        {
            gamers.Add(gamer);
        }

        public void stopPlaying()
        {
            foreach (var gamer in gamers)
            {
                gamer.StopPlaying();
            }
        }
    }



}
