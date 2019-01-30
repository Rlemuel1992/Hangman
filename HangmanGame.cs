using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
	class HangmanGame
	{
		public int tries = 0;
		public int hard = 5;
		public int medium = 10;
		public int easy = 20;
		public int ezcakes = 90000000;
		
		public string word;
       
        public List<char> guessedLetters = new List<char>();
        public List<char> foundLetters = new List<char>();
        List<string> wordBank = new List<string>{"fish","apple","tree", "dog", "rides", "scrambled" };
		Player guesser;
		public HangmanGame(Player guesser)
        {
			
			this.guesser = guesser;
            Random r = new Random();
            int index = r.Next(0,wordBank.Count);
            word = wordBank[index];
           
            Setup();
        }

        public HangmanGame(Player Guesser, string word)
        {
			this.guesser = Guesser;
            this.word = word;
            Setup();
        }

        private void Setup()
        {
            for (int i = 0; i < word.Length; i++)
            {
                foundLetters.Add('_');
            }
			
			Run();
        }

        public void Run()
        {
			//bool diffRun = true;
			//while (diffRun == true)
			//{
			//	Console.WriteLine("What difficulty would you like? \n1.Hard \n2.Medium \n3.Easy \n4.No Limit \n\n");
			//	int.TryParse(Console.ReadLine(), out int diff);
			//	if (diff == 1)
			//	{
			//		diff = hard;
			//		diffRun = false;
			//	}
			//	else if (diff == 2)
			//	{
			//		diff = medium;
			//		diffRun = false;
			//	}

			//	else if (diff == 3)
			//	{
			//		diff = easy;
			//		diffRun = false;
			//	}

			//	else if (diff == 4)
			//	{
			//		diff = ezcakes;
			//		diffRun = false;
			//	}

			//	else
			//	{
			//		Console.WriteLine("Sorry, I didn't catch that, try again");
			//		diffRun = true;
			//	}

				
			//}
			while (HasWon() == false)
            {
				
				Console.WriteLine();
                PrintProgress();
                Console.WriteLine("Please guess a letter");
				char c = guesser.Guess();
				
                PlayRound(c);
            }
            PrintProgress();
        }

        public bool HasWon()
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(foundLetters[i] != word[i])
                {
                    return false;
                }
            }
            Console.WriteLine("You won! Good Job!");
            return true;
        }

		public void PlayRound(char guess)
		{
				tries++;
				if (guessedLetters.Contains(guess))
				{
					Console.WriteLine("You already guessed that!");
					
				}
				else if (word.Contains(guess))
				{
					
					Console.WriteLine("Found a letter!");
					for (int i = 0; i < word.Length; i++)
					{
						if (word[i] == guess)
						{
							foundLetters[i] = guess;
						}
					}
					guessedLetters.Add(guess);
				}
				else
				{
					Console.WriteLine("No Letter found...");
				}
				//Console.ReadLine();
				Console.Clear();

			
		}

        public void PrintProgress()
        {
            foreach(char c in foundLetters)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("You have guessed: {0} times", tries);
        }
    }
}
