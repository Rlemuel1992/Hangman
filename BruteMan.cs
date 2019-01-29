using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
	class BruteMan : Player
	{
		public int guessNum = 0;
		public override char Guess()
		{
				return Alphabet[guessNum++];
		}
	}
}
