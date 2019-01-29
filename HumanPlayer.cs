using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
	class HumanPlayer : Player
	{
		public override char Guess()
		{
			char.TryParse(Console.ReadLine(), out char guess);
			return guess;
		}
	}
}
