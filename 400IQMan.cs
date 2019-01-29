using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
	class _400IQMan : Player
	{
		public int guessNum = 0;
		public override char Guess()
		{
			List<char> smartList = new List<char>() { 'e', 't', 'a', 'o','i', 'n', 's', 'r' ,'h' ,'l', 'd', 'c' ,'u', 'm', 'f' ,'p', 'g', 'w', 'y', 'b', 'v', 'k', 'x', 'j', 'q', 'z'};
			return smartList[guessNum++];
		}
	}
}
