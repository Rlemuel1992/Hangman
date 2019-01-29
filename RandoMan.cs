using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
	class RandoMan : Player
	{
		public int guessNum = 0;
		public override char Guess()
		{
			Random random = new Random();
			int index = random.Next(0, 25);
			return Alphabet[index];
		}
	}
}
