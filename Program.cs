using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
			Player p = new ABCplayer();
			Player p2 = new HumanPlayer();
			Player p3 = new BruteMan();
			Player p4 = new RandoMan();
			Player p5 = new _400IQMan();
            //Need to add in how to handle multi letter words like apple
            HangmanGame hg = new HangmanGame(p5);
        }
    }
}
